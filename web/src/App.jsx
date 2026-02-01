import { useState, useCallback, useMemo } from "react";

// ─── SUBNET MATH UTILITIES ──────────────────────────────────────────────────

const NETMASK_TABLE = [
  [255,255,255,255],[255,255,255,254],[255,255,255,252],[255,255,255,248],
  [255,255,255,240],[255,255,255,224],[255,255,255,192],[255,255,255,128],
  [255,255,255,0],[255,255,254,0],[255,255,252,0],[255,255,248,0],
  [255,255,240,0],[255,255,224,0],[255,255,192,0],[255,255,128,0],
  [255,255,0,0],[255,254,0,0],[255,252,0,0],[255,248,0,0],
  [255,240,0,0],[255,224,0,0],[255,192,0,0],[255,128,0,0],
  [255,0,0,0],[254,0,0,0],[252,0,0,0],[248,0,0,0],
  [240,0,0,0],[224,0,0,0],[192,0,0,0],[128,0,0,0],
  [0,0,0,0]
];

function toBin8(n) { return (n >>> 0).toString(2).padStart(8, "0"); }

function calcIPv4(ip, cidr) {
  const mask = NETMASK_TABLE[32 - cidr] || [0,0,0,0];
  const networkId = ip.map((v, i) => v & mask[i]);
  const hostBits = 32 - cidr;
  const availableHosts = hostBits >= 2 ? Math.pow(2, hostBits) - 2 : (hostBits === 1 ? 1 : (hostBits === 0 ? 1 : 0));

  let firstHost = [0,0,0,0], lastHost = [0,0,0,0], broadcast = [0,0,0,0];

  if (hostBits === 0) {
    firstHost = [...networkId];
    lastHost = [...networkId];
    broadcast = [...networkId];
  } else if (hostBits === 1) {
    // /31 point-to-point
    firstHost = [...networkId];
    firstHost[3] = networkId[3] + 1;
    lastHost = [...firstHost];
    broadcast = [...networkId];
    broadcast[3] = networkId[3] + 1;
  } else {
    // Normal: first = networkId+1, broadcast = networkId + 2^hostBits - 1, last = broadcast-1
    let nid32 = ((networkId[0] << 24) | (networkId[1] << 16) | (networkId[2] << 8) | networkId[3]) >>> 0;
    let bc32 = (nid32 + Math.pow(2, hostBits) - 1) >>> 0;
    let fh32 = (nid32 + 1) >>> 0;
    let lh32 = (bc32 - 1) >>> 0;
    firstHost = [(fh32 >>> 24) & 255, (fh32 >>> 16) & 255, (fh32 >>> 8) & 255, fh32 & 255];
    lastHost  = [(lh32 >>> 24) & 255, (lh32 >>> 16) & 255, (lh32 >>> 8) & 255, lh32 & 255];
    broadcast = [(bc32 >>> 24) & 255, (bc32 >>> 16) & 255, (bc32 >>> 8) & 255, bc32 & 255];
  }

  // Detect special ranges
  let ipType = "Public";
  let specialTag = "";
  const o1 = ip[0], o2 = ip[1];
  if (o1 === 10) { ipType = "Private"; }
  else if (o1 === 172 && o2 >= 16 && o2 <= 31) { ipType = "Private"; }
  else if (o1 === 192 && o2 === 168) { ipType = "Private"; }
  else if (o1 === 127) { ipType = "Private"; specialTag = "LOOPBACK"; }
  else if (o1 === 169 && o2 === 254) { ipType = "Private"; specialTag = "APIPA"; }
  else if (o1 >= 224 && o1 <= 239) { specialTag = "Class D (Multicast)"; }
  else if (o1 >= 240) { specialTag = "Class E (Reserved)"; }
  if (o1 === 0) { specialTag = "Not Applicable"; ipType = "—"; }

  function isPrivateRange(a) {
    if (a[0] === 10) return true;
    if (a[0] === 172 && a[1] >= 16 && a[1] <= 31) return true;
    if (a[0] === 192 && a[1] === 168) return true;
    if (a[0] === 127) return true;
    if (a[0] === 169 && a[1] === 254) return true;
    return false;
  }

  return {
    ip, cidr, mask, networkId, hostBits, availableHosts,
    firstHost, lastHost, broadcast, ipType, specialTag,
    firstHostScope: isPrivateRange(firstHost) ? "Private" : "Public",
    lastHostScope:  isPrivateRange(lastHost)  ? "Private" : "Public",
    broadcastScope: isPrivateRange(broadcast) ? "Private" : "Public",
  };
}

function calcDivideByCount(result, count) {
  if (count < 2) return "Please enter a value ≥ 2";
  const totalIPs = result.availableHosts + 2;
  let i = 0, k = 1;
  while (k < count) { k *= 2; i++; }
  const newMask = result.cidr + i;
  if (newMask > 32) return `Cannot divide: exceeds /32. Max networks possible = ${totalIPs}`;
  const networkSize = k;
  const numNetworks = Math.floor(totalIPs / networkSize);
  if (newMask >= 31) return `New mask = /${newMask} → point-to-point or host route (0 usable subnets)`;
  return `Networks requested : ${count}\nActual networks    : 2^${i} = ${networkSize} ≥ ${count}\nNew mask per subnet: /(${result.cidr} + ${i}) = /${newMask}\nSubnet size        : 2^${result.hostBits} / 2^${i} = ${numNetworks} networks`;
}

function calcDivideBySize(result, size) {
  if (size < 4) return "Minimum network size is 4 IPs (Network ID + Broadcast + 2 Hosts)";
  const totalIPs = result.availableHosts + 2;
  let i = 0, k = 1;
  while (k < size) { k *= 2; i++; }
  const networkSize = k;
  const numNetworks = Math.floor(totalIPs / networkSize);
  if (numNetworks < 1) return `Requested size ${size} (rounded to ${networkSize}) exceeds total IPs (${totalIPs})`;
  let j = 0; let k2 = 1;
  while (k2 < numNetworks) { k2 *= 2; j++; }
  const newMask = numNetworks > 1 ? result.cidr + j : result.cidr;
  if (newMask >= 31) return `New mask = /${newMask} → point-to-point or host route`;
  return `Size requested     : ${size} (rounded up to ${networkSize} = 2^${i})\nNumber of networks : 2^${result.hostBits} / 2^${i} = ${numNetworks}\nNew mask per subnet: /(${result.cidr} + ${j}) = /${newMask}`;
}

// ─── COMPONENTS ──────────────────────────────────────────────────────────────

function OctetInput({ value, onChange }) {
  return (
    <input
      type="text" inputMode="numeric"
      value={value}
      maxLength={3}
      onChange={e => {
        const raw = e.target.value.replace(/\D/g, "");
        if (raw === "") { onChange(0); return; }
        const n = Math.min(255, parseInt(raw, 10) || 0);
        onChange(n);
      }}
      style={{
        width: 56, textAlign: "center", background: "#1a1f2e", border: "1px solid #2e3650",
        borderRadius: 6, color: "#e2e8f0", fontSize: 15, fontWeight: 600, padding: "6px 0",
        fontFamily: "'JetBrains Mono', 'Fira Code', monospace", outline: "none",
        transition: "border-color .2s",
      }}
      onFocus={e => e.target.style.borderColor = "#6366f1"}
      onBlur={e => e.target.style.borderColor = "#2e3650"}
    />
  );
}

function CidrSelect({ value, onChange }) {
  return (
    <select value={value} onChange={e => onChange(Number(e.target.value))} style={{
      width: 52, background: "#1a1f2e", border: "1px solid #2e3650", borderRadius: 6,
      color: "#a5b4fc", fontSize: 14, fontWeight: 700, padding: "6px 2px", cursor: "pointer",
      fontFamily: "'JetBrains Mono', monospace", outline: "none", textAlign: "center",
    }}>
      {Array.from({length: 32}, (_, i) => 32 - i).map(n => <option key={n} value={n}>{n}</option>)}
    </select>
  );
}

function BitRow({ label, decimals, binaries, highlight }) {
  const colors = { private: "#fb923c", public: "#22d3ee", special: "#f472b6", danger: "#ef4444", default: "#e2e8f0" };
  const textColor = highlight ? (colors[highlight] || colors.default) : colors.default;
  return (
    <div style={{ display: "flex", alignItems: "center", gap: 8, marginBottom: 10 }}>
      <span style={{ width: 100, color: "#94a3b8", fontSize: 12, fontWeight: 600, textTransform: "uppercase", letterSpacing: 1, fontFamily: "sans-serif" }}>{label}</span>
      <div style={{ display: "flex", gap: 4, alignItems: "center" }}>
        {decimals.map((d, i) => (
          <span key={i} style={{
            minWidth: 42, textAlign: "center", color: textColor, fontSize: 14, fontWeight: 700,
            background: "#1a1f2e", borderRadius: 5, padding: "4px 0", border: "1px solid #2e3650",
            fontFamily: "'JetBrains Mono', monospace",
          }}>{d}</span>
        ))}
      </div>
      <span style={{ color: "#4a5568", fontSize: 11, marginLeft: 4, fontFamily: "sans-serif" }}>/</span>
      <div style={{ display: "flex", gap: 2 }}>
        {binaries.map((b, i) => (
          <span key={i} style={{
            fontSize: 9.5, letterSpacing: 0.5, color: "#64748b", fontFamily: "'JetBrains Mono', monospace",
            background: "#111827", borderRadius: 3, padding: "3px 3px",
          }}>{b}</span>
        ))}
      </div>
    </div>
  );
}

function SectionTitle({ children }) {
  return (
    <div style={{
      fontSize: 11, fontWeight: 700, color: "#6366f1", letterSpacing: 2, textTransform: "uppercase",
      borderBottom: "1px solid #2e3650", paddingBottom: 6, marginBottom: 14, marginTop: 22,
      fontFamily: "sans-serif",
    }}>{children}</div>
  );
}

function InfoBadge({ label, value, color }) {
  return (
    <span style={{
      display: "inline-flex", alignItems: "center", gap: 5, background: "#1a1f2e",
      border: `1px solid ${color || "#2e3650"}`, borderRadius: 20, padding: "4px 12px",
      fontSize: 12, color: color || "#94a3b8", fontWeight: 600, fontFamily: "sans-serif",
    }}>
      <span style={{ width: 7, height: 7, borderRadius: "50%", background: color || "#6366f1" }} />
      {label}: <strong style={{ color: "#e2e8f0", marginLeft: 3 }}>{value}</strong>
    </span>
  );
}

// ─── PRESETS ─────────────────────────────────────────────────────────────────
const IPV4_PRESETS = [
  { label: "192.168.0.0 /16", ip: [192,168,0,0], cidr: 16 },
  { label: "172.16.0.0 /12", ip: [172,16,0,0], cidr: 12 },
  { label: "10.0.0.0 /8",    ip: [10,0,0,0],   cidr: 8  },
  { label: "127.0.0.0 /8 — Loopback", ip: [127,0,0,0], cidr: 8 },
  { label: "169.254.0.0 /16 — APIPA", ip: [169,254,0,0], cidr: 16 },
  { label: "224.0.0.0 /4 — Class D", ip: [224,0,0,0], cidr: 4 },
  { label: "240.0.0.0 /4 — Class E", ip: [240,0,0,0], cidr: 4 },
];

const IPV6_PRESETS = [
  { label: "Global Unicast",      addr: ["2001","0000","0000","0000","0000","0000","0000","0000"], cidr: 3 },
  { label: "Unique Local",        addr: ["FC00","0000","0000","0000","0000","0000","0000","0000"], cidr: 7 },
  { label: "Link Local",          addr: ["FE80","0000","0000","0000","0000","0000","0000","0000"], cidr: 10 },
  { label: "Loopback ::1",        addr: ["0000","0000","0000","0000","0000","0000","0000","0001"], cidr: 128 },
  { label: "Unspecified ::",       addr: ["0000","0000","0000","0000","0000","0000","0000","0000"], cidr: 128 },
];

// ─── MAIN APP ────────────────────────────────────────────────────────────────
export default function SubnetCalculator() {
  const [tab, setTab] = useState("ipv4");
  const [ip, setIp] = useState([192, 168, 0, 0]);
  const [cidr, setCidr] = useState(16);
  const [divCount, setDivCount] = useState(10);
  const [divSize, setDivSize] = useState(10);
  const [showAbout, setShowAbout] = useState(false);

  // IPv6 state
  const [ipv6, setIpv6] = useState(["2001","0000","0000","0000","0000","0000","0000","0000"]);
  const [ipv6Cidr, setIpv6Cidr] = useState(64);

  const result = useMemo(() => calcIPv4(ip, cidr), [ip, cidr]);
  const divCountResult = useMemo(() => calcDivideByCount(result, divCount), [result, divCount]);
  const divSizeResult  = useMemo(() => calcDivideBySize(result, divSize), [result, divSize]);

  const setOctet = useCallback((i, v) => {
    setIp(prev => { const n = [...prev]; n[i] = v; return n; });
  }, []);

  const applyPreset = (p) => { setIp([...p.ip]); setCidr(p.cidr); setTab("ipv4"); };
  const applyIPv6Preset = (p) => { setIpv6([...p.addr]); setIpv6Cidr(p.cidr); setTab("ipv6"); };

  const isPrivate = result.ipType === "Private";

  // Netmask table for quick lookup
  const maskArr = NETMASK_TABLE[32 - cidr] || [0,0,0,0];

  // ─── RENDER ──────────────────────────────────────────────────────────────
  return (
    <div style={{
      minHeight: "100vh", background: "#0f1219", color: "#e2e8f0",
      fontFamily: "'Segoe UI', system-ui, sans-serif", userSelect: "none",
    }}>
      {/* ── TOP NAV ─────────────────────────────────────────────────────── */}
      <nav style={{
        background: "#111827", borderBottom: "1px solid #1e293b", padding: "10px 24px",
        display: "flex", alignItems: "center", justifyContent: "space-between", position: "sticky", top: 0, zIndex: 10,
      }}>
        <div style={{ display: "flex", alignItems: "center", gap: 12 }}>
          <div style={{
            width: 28, height: 28, borderRadius: 7, background: "linear-gradient(135deg,#6366f1,#8b5cf6)",
            display: "flex", alignItems: "center", justifyContent: "center", fontSize: 14, fontWeight: 800, color: "#fff",
          }}>S</div>
          <span style={{ fontSize: 16, fontWeight: 700, color: "#f1f5f9", letterSpacing: -0.5 }}>Subnet Calculator</span>
          <span style={{ fontSize: 10, color: "#6366f1", background: "#1e1b4b", borderRadius: 10, padding: "2px 8px", fontWeight: 600 }}>v0.2</span>
        </div>
        <div style={{ display: "flex", gap: 6 }}>
          {/* Presets dropdown */}
          <details style={{ position: "relative" }}>
            <summary style={{
              cursor: "pointer", background: "#1e293b", border: "1px solid #2e3650", borderRadius: 6,
              color: "#a5b4fc", fontSize: 12, fontWeight: 600, padding: "5px 12px", listStyle: "none",
            }}>⚡ Presets ▾</summary>
            <div style={{
              position: "absolute", top: "calc(100% + 4px)", right: 0, background: "#1e293b",
              border: "1px solid #2e3650", borderRadius: 8, minWidth: 220, zIndex: 100,
              boxShadow: "0 8px 32px rgba(0,0,0,.4)", padding: "6px 0",
            }}>
              <div style={{ fontSize: 9, color: "#6366f1", letterSpacing: 1.5, textTransform: "uppercase", fontWeight: 700, padding: "4px 12px 2px" }}>IPv4</div>
              {IPV4_PRESETS.map((p, i) => (
                <div key={i} onClick={() => applyPreset(p)} style={{
                  padding: "5px 12px", cursor: "pointer", fontSize: 12, color: "#cbd5e1",
                  transition: "background .15s",
                }}
                  onMouseEnter={e => e.target.style.background = "#1a1f2e"}
                  onMouseLeave={e => e.target.style.background = "transparent"}
                >{p.label}</div>
              ))}
              <div style={{ fontSize: 9, color: "#6366f1", letterSpacing: 1.5, textTransform: "uppercase", fontWeight: 700, padding: "8px 12px 2px" }}>IPv6</div>
              {IPV6_PRESETS.map((p, i) => (
                <div key={i} onClick={() => applyIPv6Preset(p)} style={{
                  padding: "5px 12px", cursor: "pointer", fontSize: 12, color: "#cbd5e1",
                  transition: "background .15s",
                }}
                  onMouseEnter={e => e.target.style.background = "#1a1f2e"}
                  onMouseLeave={e => e.target.style.background = "transparent"}
                >{p.label}</div>
              ))}
            </div>
          </details>
          <button onClick={() => setShowAbout(true)} style={{
            background: "#1e293b", border: "1px solid #2e3650", borderRadius: 6,
            color: "#94a3b8", fontSize: 12, fontWeight: 600, padding: "5px 10px", cursor: "pointer",
          }}>About</button>
        </div>
      </nav>

      {/* ── TAB BAR ─────────────────────────────────────────────────────── */}
      <div style={{ display: "flex", gap: 2, padding: "12px 24px 0", background: "#0f1219" }}>
        {["ipv4","ipv6"].map(t => (
          <button key={t} onClick={() => setTab(t)} style={{
            background: tab === t ? "#1e1b4b" : "transparent",
            border: tab === t ? "1px solid #6366f1" : "1px solid transparent",
            borderRadius: "8px 8px 0 0", color: tab === t ? "#a5b4fc" : "#64748b",
            fontSize: 13, fontWeight: 700, padding: "8px 28px", cursor: "pointer",
            textTransform: "uppercase", letterSpacing: 2, transition: "all .2s",
          }}>{t}</button>
        ))}
      </div>

      {/* ── CONTENT ─────────────────────────────────────────────────────── */}
      <div style={{ padding: "20px 24px 40px", maxWidth: 900, margin: "0 auto" }}>

        {/* ═══════════════════ IPv4 TAB ═══════════════════════════════════ */}
        {tab === "ipv4" && (
          <div>
            {/* Input row */}
            <div style={{
              background: "#111827", border: "1px solid #1e293b", borderRadius: 12, padding: "18px 22px",
              display: "flex", alignItems: "center", gap: 6, flexWrap: "wrap",
            }}>
              <span style={{ fontSize: 11, color: "#6366f1", fontWeight: 700, letterSpacing: 1, textTransform: "uppercase", marginRight: 6, fontFamily: "sans-serif" }}>IP</span>
              {ip.map((v, i) => (
                <React.Fragment key={i}>
                  <OctetInput value={v} onChange={val => setOctet(i, val)} />
                  {i < 3 && <span style={{ color: "#4a5568", fontSize: 18, fontWeight: 700 }}>.</span>}
                </React.Fragment>
              ))}
              <span style={{ color: "#4a5568", fontSize: 18, fontWeight: 700, marginLeft: 8 }}>/</span>
              <CidrSelect value={cidr} onChange={setCidr} />
              <span style={{ fontSize: 11, color: "#4a5568", marginLeft: 12, fontFamily: "sans-serif" }}>
                = {maskArr.join(".")}
              </span>
            </div>

            {/* Status badges */}
            <div style={{ display: "flex", gap: 8, marginTop: 12, flexWrap: "wrap" }}>
              <InfoBadge label="Type" value={result.ipType} color={isPrivate ? "#fb923c" : "#22d3ee"} />
              <InfoBadge label="Host Bits" value={`${result.hostBits} (n = 32 − ${cidr})`} color="#6366f1" />
              <InfoBadge label="Usable Hosts" value={result.availableHosts.toLocaleString()} color="#a78bfa" />
              {result.specialTag && <InfoBadge label="Special" value={result.specialTag} color="#f472b6" />}
            </div>

            {/* Bit table */}
            <div style={{ marginTop: 20 }}>
              <SectionTitle>Address Breakdown</SectionTitle>
              <BitRow label="Network Addr"  decimals={ip}                  binaries={ip.map(toBin8)} />
              <BitRow label="Subnet Mask"   decimals={maskArr}             binaries={maskArr.map(toBin8)} />
              <BitRow label="Network ID"    decimals={result.networkId}    binaries={result.networkId.map(toBin8)} highlight={isPrivate ? "private" : "public"} />
              <BitRow label="First Host"    decimals={result.firstHost}    binaries={result.firstHost.map(toBin8)} highlight={isPrivate ? "private" : "public"} />
              <BitRow label="Last Host"     decimals={result.lastHost}     binaries={result.lastHost.map(toBin8)} highlight={isPrivate ? "private" : "public"} />
              <BitRow label="Broadcast"     decimals={result.broadcast}    binaries={result.broadcast.map(toBin8)} highlight={isPrivate ? "private" : "public"} />
            </div>

            {/* Scope labels */}
            <div style={{ display: "flex", gap: 16, marginTop: 10, flexWrap: "wrap" }}>
              {[
                ["First Host", result.firstHostScope],
                ["Last Host",  result.lastHostScope],
                ["Broadcast",  result.broadcastScope],
              ].map(([lbl, scope]) => (
                <span key={lbl} style={{ fontSize: 11, color: scope === "Private" ? "#fb923c" : "#22d3ee", fontWeight: 600, fontFamily: "sans-serif" }}>
                  {lbl}: {scope}
                </span>
              ))}
            </div>

            {/* Network Division */}
            <div style={{ marginTop: 28 }}>
              <SectionTitle>Network Division</SectionTitle>
              <div style={{ display: "flex", gap: 16, flexWrap: "wrap" }}>
                {/* By count */}
                <div style={{ flex: "1 1 260px", background: "#111827", border: "1px solid #1e293b", borderRadius: 10, padding: 16 }}>
                  <div style={{ fontSize: 11, color: "#64748b", fontWeight: 600, marginBottom: 8, textTransform: "uppercase", letterSpacing: 1 }}>By Number of Networks</div>
                  <div style={{ display: "flex", gap: 8, alignItems: "center" }}>
                    <input type="number" min={2} value={divCount} onChange={e => setDivCount(Math.max(2, parseInt(e.target.value) || 2))} style={{
                      width: 70, background: "#1a1f2e", border: "1px solid #2e3650", borderRadius: 6,
                      color: "#e2e8f0", fontSize: 14, padding: "6px 8px", fontFamily: "'JetBrains Mono', monospace", outline: "none",
                    }} />
                    <span style={{ fontSize: 11, color: "#64748b" }}>networks</span>
                  </div>
                  <pre style={{
                    marginTop: 10, background: "#0f1219", borderRadius: 6, padding: "10px 12px",
                    fontSize: 11.5, color: "#94a3b8", whiteSpace: "pre-wrap", lineHeight: 1.7,
                    fontFamily: "'JetBrains Mono', monospace", border: "1px solid #1e293b", minHeight: 68,
                  }}>{divCountResult}</pre>
                </div>
                {/* By size */}
                <div style={{ flex: "1 1 260px", background: "#111827", border: "1px solid #1e293b", borderRadius: 10, padding: 16 }}>
                  <div style={{ fontSize: 11, color: "#64748b", fontWeight: 600, marginBottom: 8, textTransform: "uppercase", letterSpacing: 1 }}>By Size of Networks</div>
                  <div style={{ display: "flex", gap: 8, alignItems: "center" }}>
                    <input type="number" min={4} value={divSize} onChange={e => setDivSize(Math.max(4, parseInt(e.target.value) || 4))} style={{
                      width: 70, background: "#1a1f2e", border: "1px solid #2e3650", borderRadius: 6,
                      color: "#e2e8f0", fontSize: 14, padding: "6px 8px", fontFamily: "'JetBrains Mono', monospace", outline: "none",
                    }} />
                    <span style={{ fontSize: 11, color: "#64748b" }}>IPs per subnet</span>
                  </div>
                  <pre style={{
                    marginTop: 10, background: "#0f1219", borderRadius: 6, padding: "10px 12px",
                    fontSize: 11.5, color: "#94a3b8", whiteSpace: "pre-wrap", lineHeight: 1.7,
                    fontFamily: "'JetBrains Mono', monospace", border: "1px solid #1e293b", minHeight: 68,
                  }}>{divSizeResult}</pre>
                </div>
              </div>
            </div>
          </div>
        )}

        {/* ═══════════════════ IPv6 TAB ═══════════════════════════════════ */}
        {tab === "ipv6" && (
          <div>
            <div style={{
              background: "#111827", border: "1px solid #1e293b", borderRadius: 12, padding: "18px 22px",
            }}>
              <div style={{ fontSize: 11, color: "#6366f1", fontWeight: 700, letterSpacing: 1, textTransform: "uppercase", marginBottom: 10 }}>IPv6 Address</div>
              <div style={{ display: "flex", gap: 4, alignItems: "center", flexWrap: "wrap" }}>
                {ipv6.map((block, i) => (
                  <React.Fragment key={i}>
                    <input
                      type="text" value={block} maxLength={4}
                      onChange={e => {
                        const val = e.target.value.replace(/[^0-9a-fA-F]/g, "").toUpperCase().slice(0, 4);
                        const n = [...ipv6]; n[i] = val.padStart(4, "0"); setIpv6(n);
                      }}
                      style={{
                        width: 62, textAlign: "center", background: "#1a1f2e", border: "1px solid #2e3650",
                        borderRadius: 6, color: "#a5b4fc", fontSize: 14, fontWeight: 700, padding: "6px 0",
                        fontFamily: "'JetBrains Mono', monospace", outline: "none",
                      }}
                      onFocus={e => e.target.style.borderColor = "#6366f1"}
                      onBlur={e => e.target.style.borderColor = "#2e3650"}
                    />
                    {i < 7 && <span style={{ color: "#4a5568", fontSize: 16, fontWeight: 700 }}>:</span>}
                  </React.Fragment>
                ))}
                <span style={{ color: "#4a5568", fontSize: 18, fontWeight: 700, marginLeft: 8 }}>/</span>
                <select value={ipv6Cidr} onChange={e => setIpv6Cidr(Number(e.target.value))} style={{
                  width: 52, background: "#1a1f2e", border: "1px solid #2e3650", borderRadius: 6,
                  color: "#a5b4fc", fontSize: 14, fontWeight: 700, padding: "6px 2px", cursor: "pointer",
                  fontFamily: "'JetBrains Mono', monospace", outline: "none",
                }}>
                  {Array.from({length: 128}, (_, i) => 128 - i).map(n => <option key={n} value={n}>{n}</option>)}
                </select>
              </div>
            </div>

            {/* IPv6 display */}
            <div style={{ marginTop: 20 }}>
              <SectionTitle>IPv6 Details</SectionTitle>
              <div style={{ background: "#111827", border: "1px solid #1e293b", borderRadius: 10, padding: 16 }}>
                <div style={{ display: "flex", gap: 24, flexWrap: "wrap" }}>
                  <div>
                    <div style={{ fontSize: 10, color: "#64748b", fontWeight: 600, textTransform: "uppercase", letterSpacing: 1, marginBottom: 4 }}>Full Address</div>
                    <div style={{ fontSize: 13, color: "#a5b4fc", fontFamily: "'JetBrains Mono', monospace", fontWeight: 600 }}>
                      {ipv6.join(":")}
                    </div>
                  </div>
                  <div>
                    <div style={{ fontSize: 10, color: "#64748b", fontWeight: 600, textTransform: "uppercase", letterSpacing: 1, marginBottom: 4 }}>Compressed</div>
                    <div style={{ fontSize: 13, color: "#e2e8f0", fontFamily: "'JetBrains Mono', monospace", fontWeight: 600 }}>
                      {(() => {
                        const s = ipv6.map(b => parseInt(b, 16).toString(16));
                        // Simple zero compression
                        let best = -1, bestLen = 0, cur = -1, curLen = 0;
                        s.forEach((v, i) => {
                          if (v === "0") { if (cur < 0) cur = i; curLen++; if (curLen > bestLen) { best = cur; bestLen = curLen; } }
                          else { cur = -1; curLen = 0; }
                        });
                        if (bestLen >= 2) {
                          const before = s.slice(0, best).join(":");
                          const after = s.slice(best + bestLen).join(":");
                          return (before ? before : "") + "::" + (after ? after : "");
                        }
                        return s.join(":");
                      })()}
                    </div>
                  </div>
                  <div>
                    <div style={{ fontSize: 10, color: "#64748b", fontWeight: 600, textTransform: "uppercase", letterSpacing: 1, marginBottom: 4 }}>Prefix Length</div>
                    <div style={{ fontSize: 13, color: "#6366f1", fontFamily: "'JetBrains Mono', monospace", fontWeight: 700 }}>/{ipv6Cidr}</div>
                  </div>
                  <div>
                    <div style={{ fontSize: 10, color: "#64748b", fontWeight: 600, textTransform: "uppercase", letterSpacing: 1, marginBottom: 4 }}>Host Bits</div>
                    <div style={{ fontSize: 13, color: "#a78bfa", fontFamily: "'JetBrains Mono', monospace", fontWeight: 700 }}>{128 - ipv6Cidr}</div>
                  </div>
                </div>

                {/* Binary representation */}
                <div style={{ marginTop: 16 }}>
                  <div style={{ fontSize: 10, color: "#64748b", fontWeight: 600, textTransform: "uppercase", letterSpacing: 1, marginBottom: 6 }}>Binary (128 bits)</div>
                  <div style={{ display: "flex", flexWrap: "wrap", gap: 3 }}>
                    {ipv6.map((block, bi) => {
                      const val = parseInt(block, 16);
                      const bin = val.toString(2).padStart(16, "0");
                      return bin.split("").map((bit, i) => {
                        const globalIdx = bi * 16 + i;
                        const isNetwork = globalIdx < ipv6Cidr;
                        return (
                          <span key={`${bi}-${i}`} style={{
                            display: "inline-block", width: 11, height: 16, lineHeight: "16px", textAlign: "center",
                            fontSize: 9, fontFamily: "'JetBrains Mono', monospace",
                            background: isNetwork ? (bit === "1" ? "#6366f1" : "#312e81") : (bit === "1" ? "#374151" : "#1a1f2e"),
                            color: isNetwork ? "#e0e7ff" : "#64748b",
                            borderRadius: 1,
                          }}>{bit}</span>
                        );
                      });
                    })}
                  </div>
                  <div style={{ display: "flex", gap: 16, marginTop: 8, fontSize: 10, color: "#64748b" }}>
                    <span style={{ display: "flex", alignItems: "center", gap: 4 }}><span style={{ width: 10, height: 10, borderRadius: 2, background: "#6366f1", display: "inline-block" }} /> Network prefix ({ipv6Cidr} bits)</span>
                    <span style={{ display: "flex", alignItems: "center", gap: 4 }}><span style={{ width: 10, height: 10, borderRadius: 2, background: "#374151", display: "inline-block" }} /> Host part ({128-ipv6Cidr} bits)</span>
                  </div>
                </div>

                {/* Scope detection */}
                <div style={{ marginTop: 16 }}>
                  {(() => {
                    const f = ipv6[0].toUpperCase();
                    let scope = "Global Unicast";
                    if (f === "FE80") scope = "Link-Local Unicast";
                    else if (f === "FC00" || f === "FD00") scope = "Unique Local Unicast";
                    else if (f === "FF00" || f.startsWith("FF")) scope = "Multicast";
                    else if (ipv6.every(b => b === "0000") && ipv6[7] === "0000") scope = "Unspecified (::)";
                    else if (ipv6.slice(0,7).every(b => b === "0000") && ipv6[7] === "0001") scope = "Loopback (::1)";
                    return <InfoBadge label="Scope" value={scope} color="#6366f1" />;
                  })()}
                </div>
              </div>
            </div>
          </div>
        )}
      </div>

      {/* ── ABOUT MODAL ─────────────────────────────────────────────────── */}
      {showAbout && (
        <div style={{
          position: "fixed", inset: 0, background: "rgba(0,0,0,.6)", display: "flex",
          alignItems: "center", justifyContent: "center", zIndex: 999,
        }} onClick={() => setShowAbout(false)}>
          <div onClick={e => e.stopPropagation()} style={{
            background: "#111827", border: "1px solid #2e3650", borderRadius: 14, padding: 28,
            maxWidth: 440, width: "90%", color: "#cbd5e1", fontSize: 13, lineHeight: 1.7,
          }}>
            <div style={{ fontSize: 18, fontWeight: 700, color: "#e2e8f0", marginBottom: 12 }}>Subnet Calculator <span style={{ fontSize: 12, color: "#6366f1" }}>v0.2</span></div>
            <p style={{ margin: "0 0 6px" }}><strong style={{ color: "#a5b4fc" }}>Author:</strong> Bayram Kotan</p>
            <p style={{ margin: "0 0 6px" }}><strong style={{ color: "#a5b4fc" }}>Email:</strong> bayramkotan@gmail.com</p>
            <p style={{ margin: "0 0 14px" }}><strong style={{ color: "#a5b4fc" }}>Website:</strong> bayramkotan.com</p>
            <p style={{ margin: 0, fontSize: 11, color: "#64748b", borderTop: "1px solid #1e293b", paddingTop: 12 }}>
              © 2020 — This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License (v3 or later). See <a href="http://www.gnu.org/licenses/" style={{ color: "#6366f1" }} target="_blank" rel="noreferrer">gnu.org/licenses</a>
            </p>
            <button onClick={() => setShowAbout(false)} style={{
              marginTop: 16, background: "#6366f1", border: "none", borderRadius: 6, color: "#fff",
              fontSize: 12, fontWeight: 600, padding: "6px 20px", cursor: "pointer",
            }}>Close</button>
          </div>
        </div>
      )}
    </div>
  );
}
