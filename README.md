<div align="center">

# 🌐 Subnet Calculator

### IPv4 & IPv6 Subnet Hesap Aleti

[![Language](https://img.shields.io/badge/Language-C%23%20%2F%20WinForms-239120?style=for-the-badge&logo=csharp)](https://en.wikipedia.org/wiki/C_Sharp_(programming_language))
[![Web](https://img.shields.io/badge/Web-React%20%2B%20Vite-61DAFB?style=for-the-badge&logo=react)](https://bayramkotan.github.io/subnet-calculator/)
[![License](https://img.shields.io/badge/License-GPL%20v3-ee0701?style=for-the-badge)](LICENSE)

<br>

🖥️ **Desktop (C# WinForms)** | ⚛️ **[Web Demo](https://bayramkotan.github.io/subnet-calculator/)**

</div>

---

<div align="center">

## 🚀 Live Demo

👉 **[https://bayramkotan.github.io/subnet-calculator/](https://bayramkotan.github.io/subnet-calculator/)**

</div>

---

## ✨ Features

### IPv4
- Network ID, First Host, Last Host, Broadcast hesabı
- Binary (bit-level) breakdown — AND operasyonu ile
- Subnet Mask otomatik hesap (CIDR → Dotted Notation)
- Private / Public IP tespiti
- Special range detection: **Loopback**, **APIPA**, **Class D**, **Class E**
- `/31` (point-to-point) ve `/32` (host route) edge case desteği
- **Network Division** — Network sayısına göre ve boyuta göre

### IPv6
- 8 blok hex girişi + Prefix length (/1–/128)
- Full → Compressed (:: notation) dönüşüm
- 128-bit binary visualization (network prefix vs host)
- Scope detection: Global Unicast, Link-Local, ULA, Multicast, Loopback

### Presets
- Private IP ranges: `192.168.0.0/16`, `172.16.0.0/12`, `10.0.0.0/8`
- Special: Loopback, APIPA, Class D, Class E
- IPv6: Global Unicast, Unique Local, Link-Local, Loopback, Unspecified

---

## 💻 Local Development (Web)

```bash
cd web
npm install
npm run dev        # → http://localhost:5173
npm run build      # → Production build
npm run preview    # → Preview build
```

---

## 📁 Project Structure

```
subnet-calculator/
│
├── .github/
│   └── workflows/
│       └── deploy.yml          ← Auto deploy to GitHub Pages
│
├── web/                        ← React Web App
│   ├── src/
│   │   ├── App.jsx             ← Subnet calculator
│   │   └── main.jsx            ← Entry point
│   ├── index.html
│   ├── package.json
│   └── vite.config.js
│
├── MainForm.cs                 ← C# WinForms (Desktop)
├── MainForm_Designer.cs
├── Program.cs
├── about.cs
├── SubnetCalculator.csproj
│
├── README.md
├── LICENSE
└── .gitignore
```

---

## 📜 Version History

| Version | Year | Platform | Description |
|:-------:|:----:|:--------:|:------------|
| `0.2` | 2024 | Web | React + Vite |
| `0.2` | 2018 | Desktop | C# WinForms / SharpDevelop |

---

<div align="center">

### 👨‍💻 Developer

**Bayram Kotan**

[![GitHub](https://img.shields.io/badge/GitHub-bayramkotan-181717?style=flat-square&logo=github)](https://github.com/bayramkotan)
&nbsp;&nbsp;
[![Email](https://img.shields.io/badge/Email-bayramkotan@gmail.com-EA4335?style=flat-square&logo=gmail&logoColor=white)](mailto:bayramkotan@gmail.com)

<br>

<sub>Licensed under the GNU General Public License v3 — see [LICENSE](LICENSE)</sub>

</div>
