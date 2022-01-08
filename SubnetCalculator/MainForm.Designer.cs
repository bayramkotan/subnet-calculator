/*
 * Created by SharpDevelop.
 * User: bayram
 * Date: 9/22/2018
 * Time: 11:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SubnetCalculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox firstDigitTXT;
		private System.Windows.Forms.TextBox secondDigitTXT;
		private System.Windows.Forms.TextBox thirdDigitTXT;
		private System.Windows.Forms.TextBox fourthDigitTXT;
		private System.Windows.Forms.ComboBox cmbMaskBit;
		private System.Windows.Forms.Label netmaskLabel;
		private System.Windows.Forms.ComboBox cmbNetMaskDigit1;
		private System.Windows.Forms.ComboBox cmbNetMaskDigit2;
		private System.Windows.Forms.ComboBox cmbNetMaskDigit3;
		private System.Windows.Forms.ComboBox cmbNetMaskDigit4;
		private System.Windows.Forms.Label lblNetMaskDigit1;
		private System.Windows.Forms.Label lblNetMaskDigit2;
		private System.Windows.Forms.Label lblNetMaskDigit3;
		private System.Windows.Forms.Label lblNetMaskDigit4;
		private System.Windows.Forms.Label lblNetworkDigit1;
		private System.Windows.Forms.Label lblNetworkDigit2;
		private System.Windows.Forms.Label lblNetworkDigit3;
		private System.Windows.Forms.Label lblNetworkDigit4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblHostNumber;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblHostbit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblHostbit2;
		private System.Windows.Forms.Label lblHostNumber2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblFourthNetworkIDBits;
		private System.Windows.Forms.Label lblThirdNetworkIDBits;
		private System.Windows.Forms.Label lblSecondNetworkIDBits;
		private System.Windows.Forms.Label lblFirstNetworkIDBits;
		private System.Windows.Forms.Label lblFourthNetworkID;
		private System.Windows.Forms.Label lblThirdNetworkID;
		private System.Windows.Forms.Label lblSecondNetworkID;
		private System.Windows.Forms.Label lblFirstNetworkID;
		private System.Windows.Forms.Label lblFirstHost4;
		private System.Windows.Forms.Label lblFirstHost3;
		private System.Windows.Forms.Label lblFirstHost2;
		private System.Windows.Forms.Label lblFirstHost1;
		private System.Windows.Forms.Label lblFirstHost4Bits;
		private System.Windows.Forms.Label lblFirstHost3Bits;
		private System.Windows.Forms.Label lblFirstHost2Bits;
		private System.Windows.Forms.Label lblFirstHost1Bits;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lblLastHost4;
		private System.Windows.Forms.Label lblLastHost3;
		private System.Windows.Forms.Label lblLastHost2;
		private System.Windows.Forms.Label lblLastHost1;
		private System.Windows.Forms.Label lblLastHost4Bits;
		private System.Windows.Forms.Label lblLastHost3Bits;
		private System.Windows.Forms.Label lblLastHost2Bits;
		private System.Windows.Forms.Label lblLastHost1Bits;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblBC_IP4;
		private System.Windows.Forms.Label lblBC_IP3;
		private System.Windows.Forms.Label lblBC_IP2;
		private System.Windows.Forms.Label lblBC_IP1;
		private System.Windows.Forms.Label lblBC_IP4Bits;
		private System.Windows.Forms.Label lblBC_IP3Bits;
		private System.Windows.Forms.Label lblBC_IP2Bits;
		private System.Windows.Forms.Label lblBC_IP1Bits;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblMaskBit;
		private System.Windows.Forms.Label lblPublicPrivateIP;
		private System.Windows.Forms.Label lblFirstDigtZero;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem privateIPsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem xXToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem netmaskToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolMask32;
		private System.Windows.Forms.ToolStripMenuItem toolMask31;
		private System.Windows.Forms.ToolStripMenuItem toolMask30;
		private System.Windows.Forms.ToolStripMenuItem toolMask29;
		private System.Windows.Forms.ToolStripMenuItem toolMask28;
		private System.Windows.Forms.ToolStripMenuItem toolMask27;
		private System.Windows.Forms.ToolStripMenuItem toolMask26;
		private System.Windows.Forms.ToolStripMenuItem toolMask25;
		private System.Windows.Forms.ToolStripMenuItem toolMask24;
		private System.Windows.Forms.ToolStripMenuItem toolMask23;
		private System.Windows.Forms.ToolStripMenuItem toolMask22;
		private System.Windows.Forms.ToolStripMenuItem toolMask21;
		private System.Windows.Forms.ToolStripMenuItem toolMask20;
		private System.Windows.Forms.ToolStripMenuItem toolMask19;
		private System.Windows.Forms.ToolStripMenuItem toolMask18;
		private System.Windows.Forms.ToolStripMenuItem toolMask17;
		private System.Windows.Forms.ToolStripMenuItem toolMask16;
		private System.Windows.Forms.ToolStripMenuItem toolMask15;
		private System.Windows.Forms.ToolStripMenuItem toolMask14;
		private System.Windows.Forms.ToolStripMenuItem toolMask13;
		private System.Windows.Forms.ToolStripMenuItem toolMask12;
		private System.Windows.Forms.ToolStripMenuItem toolMask11;
		private System.Windows.Forms.ToolStripMenuItem toolMask09;
		private System.Windows.Forms.ToolStripMenuItem toolMask08;
		private System.Windows.Forms.ToolStripMenuItem toolMask07;
		private System.Windows.Forms.ToolStripMenuItem toolMask06;
		private System.Windows.Forms.ToolStripMenuItem toolMask05;
		private System.Windows.Forms.ToolStripMenuItem toolMask04;
		private System.Windows.Forms.ToolStripMenuItem toolMask03;
		private System.Windows.Forms.ToolStripMenuItem toolMask02;
		private System.Windows.Forms.ToolStripMenuItem toolMask01;
		private System.Windows.Forms.ToolStripMenuItem toolMask10;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.firstDigitTXT = new System.Windows.Forms.TextBox();
            this.secondDigitTXT = new System.Windows.Forms.TextBox();
            this.thirdDigitTXT = new System.Windows.Forms.TextBox();
            this.fourthDigitTXT = new System.Windows.Forms.TextBox();
            this.cmbMaskBit = new System.Windows.Forms.ComboBox();
            this.netmaskLabel = new System.Windows.Forms.Label();
            this.cmbNetMaskDigit1 = new System.Windows.Forms.ComboBox();
            this.cmbNetMaskDigit2 = new System.Windows.Forms.ComboBox();
            this.cmbNetMaskDigit3 = new System.Windows.Forms.ComboBox();
            this.cmbNetMaskDigit4 = new System.Windows.Forms.ComboBox();
            this.lblNetMaskDigit1 = new System.Windows.Forms.Label();
            this.lblNetMaskDigit2 = new System.Windows.Forms.Label();
            this.lblNetMaskDigit3 = new System.Windows.Forms.Label();
            this.lblNetMaskDigit4 = new System.Windows.Forms.Label();
            this.lblNetworkDigit1 = new System.Windows.Forms.Label();
            this.lblNetworkDigit2 = new System.Windows.Forms.Label();
            this.lblNetworkDigit3 = new System.Windows.Forms.Label();
            this.lblNetworkDigit4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHostNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHostbit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHostbit2 = new System.Windows.Forms.Label();
            this.lblHostNumber2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFourthNetworkIDBits = new System.Windows.Forms.Label();
            this.lblThirdNetworkIDBits = new System.Windows.Forms.Label();
            this.lblSecondNetworkIDBits = new System.Windows.Forms.Label();
            this.lblFirstNetworkIDBits = new System.Windows.Forms.Label();
            this.lblFourthNetworkID = new System.Windows.Forms.Label();
            this.lblThirdNetworkID = new System.Windows.Forms.Label();
            this.lblSecondNetworkID = new System.Windows.Forms.Label();
            this.lblFirstNetworkID = new System.Windows.Forms.Label();
            this.lblFirstHost4 = new System.Windows.Forms.Label();
            this.lblFirstHost3 = new System.Windows.Forms.Label();
            this.lblFirstHost2 = new System.Windows.Forms.Label();
            this.lblFirstHost1 = new System.Windows.Forms.Label();
            this.lblFirstHost4Bits = new System.Windows.Forms.Label();
            this.lblFirstHost3Bits = new System.Windows.Forms.Label();
            this.lblFirstHost2Bits = new System.Windows.Forms.Label();
            this.lblFirstHost1Bits = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLastHost4 = new System.Windows.Forms.Label();
            this.lblLastHost3 = new System.Windows.Forms.Label();
            this.lblLastHost2 = new System.Windows.Forms.Label();
            this.lblLastHost1 = new System.Windows.Forms.Label();
            this.lblLastHost4Bits = new System.Windows.Forms.Label();
            this.lblLastHost3Bits = new System.Windows.Forms.Label();
            this.lblLastHost2Bits = new System.Windows.Forms.Label();
            this.lblLastHost1Bits = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBC_IP4 = new System.Windows.Forms.Label();
            this.lblBC_IP3 = new System.Windows.Forms.Label();
            this.lblBC_IP2 = new System.Windows.Forms.Label();
            this.lblBC_IP1 = new System.Windows.Forms.Label();
            this.lblBC_IP4Bits = new System.Windows.Forms.Label();
            this.lblBC_IP3Bits = new System.Windows.Forms.Label();
            this.lblBC_IP2Bits = new System.Windows.Forms.Label();
            this.lblBC_IP1Bits = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaskBit = new System.Windows.Forms.Label();
            this.lblPublicPrivateIP = new System.Windows.Forms.Label();
            this.lblFirstDigtZero = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateIPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.xXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.classEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netmaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask31 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask29 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask28 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask09 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask08 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask07 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask06 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask05 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask04 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask03 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask02 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMask01 = new System.Windows.Forms.ToolStripMenuItem();
            this.unicastIPv6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.globalUnicastAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniqueLocalUncastAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLocalUnicastAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopbackAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unspecifiedAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multicastIPv6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anycastIPv6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabIPv4 = new System.Windows.Forms.TabPage();
            this.lbl_broadcast = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.lbl_first = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.divideNetwork2 = new System.Windows.Forms.Button();
            this.txtSizeOfNetwork = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_number_of_networks = new System.Windows.Forms.Label();
            this.divideNetwork = new System.Windows.Forms.Button();
            this.txtNumberOfNetwork = new System.Windows.Forms.TextBox();
            this.tabIPv6 = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_IPv6MaskBit = new System.Windows.Forms.ComboBox();
            this.txtIPv6_8Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_7Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_6Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_5Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_4Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_3Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_2Block = new System.Windows.Forms.TextBox();
            this.txtIPv6_1Block = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabIPv4.SuspendLayout();
            this.tabIPv6.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstDigitTXT
            // 
            this.firstDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDigitTXT.Location = new System.Drawing.Point(176, 24);
            this.firstDigitTXT.Name = "firstDigitTXT";
            this.firstDigitTXT.Size = new System.Drawing.Size(70, 20);
            this.firstDigitTXT.TabIndex = 0;
            this.firstDigitTXT.TextChanged += new System.EventHandler(this.FirstDigitTXTTextChanged);
            this.firstDigitTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            this.firstDigitTXT.Leave += new System.EventHandler(this.noempty);
            // 
            // secondDigitTXT
            // 
            this.secondDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDigitTXT.Location = new System.Drawing.Point(252, 23);
            this.secondDigitTXT.Name = "secondDigitTXT";
            this.secondDigitTXT.Size = new System.Drawing.Size(70, 20);
            this.secondDigitTXT.TabIndex = 1;
            this.secondDigitTXT.TextChanged += new System.EventHandler(this.SecondDigitTXTTextChanged);
            this.secondDigitTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            this.secondDigitTXT.Leave += new System.EventHandler(this.noempty);
            // 
            // thirdDigitTXT
            // 
            this.thirdDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdDigitTXT.Location = new System.Drawing.Point(328, 23);
            this.thirdDigitTXT.Name = "thirdDigitTXT";
            this.thirdDigitTXT.Size = new System.Drawing.Size(70, 20);
            this.thirdDigitTXT.TabIndex = 2;
            this.thirdDigitTXT.TextChanged += new System.EventHandler(this.ThirdDigitTXTTextChanged);
            this.thirdDigitTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            this.thirdDigitTXT.Leave += new System.EventHandler(this.noempty);
            // 
            // fourthDigitTXT
            // 
            this.fourthDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthDigitTXT.Location = new System.Drawing.Point(404, 23);
            this.fourthDigitTXT.Name = "fourthDigitTXT";
            this.fourthDigitTXT.Size = new System.Drawing.Size(70, 20);
            this.fourthDigitTXT.TabIndex = 3;
            this.fourthDigitTXT.TextChanged += new System.EventHandler(this.FourthDigitTXTTextChanged);
            this.fourthDigitTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            this.fourthDigitTXT.Leave += new System.EventHandler(this.noempty);
            // 
            // cmbMaskBit
            // 
            this.cmbMaskBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaskBit.FormattingEnabled = true;
            this.cmbMaskBit.Location = new System.Drawing.Point(514, 22);
            this.cmbMaskBit.Name = "cmbMaskBit";
            this.cmbMaskBit.Size = new System.Drawing.Size(58, 21);
            this.cmbMaskBit.TabIndex = 4;
            this.cmbMaskBit.SelectedIndexChanged += new System.EventHandler(this.cmbMaskBitSelectedIndexChanged);
            this.cmbMaskBit.TextChanged += new System.EventHandler(this.CmbMaskBitTextChanged);
            this.cmbMaskBit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            this.cmbMaskBit.Leave += new System.EventHandler(this.CmbMaskBitLeave);
            // 
            // netmaskLabel
            // 
            this.netmaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netmaskLabel.Location = new System.Drawing.Point(485, 23);
            this.netmaskLabel.Name = "netmaskLabel";
            this.netmaskLabel.Size = new System.Drawing.Size(23, 23);
            this.netmaskLabel.TabIndex = 5;
            this.netmaskLabel.Text = "/";
            // 
            // cmbNetMaskDigit1
            // 
            this.cmbNetMaskDigit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbNetMaskDigit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNetMaskDigit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNetMaskDigit1.FormattingEnabled = true;
            this.cmbNetMaskDigit1.Location = new System.Drawing.Point(176, 82);
            this.cmbNetMaskDigit1.Name = "cmbNetMaskDigit1";
            this.cmbNetMaskDigit1.Size = new System.Drawing.Size(70, 21);
            this.cmbNetMaskDigit1.TabIndex = 6;
            this.cmbNetMaskDigit1.TextChanged += new System.EventHandler(this.cmbMaskBitSelectedIndexChanged);
            // 
            // cmbNetMaskDigit2
            // 
            this.cmbNetMaskDigit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbNetMaskDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNetMaskDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNetMaskDigit2.FormattingEnabled = true;
            this.cmbNetMaskDigit2.Location = new System.Drawing.Point(252, 82);
            this.cmbNetMaskDigit2.Name = "cmbNetMaskDigit2";
            this.cmbNetMaskDigit2.Size = new System.Drawing.Size(70, 21);
            this.cmbNetMaskDigit2.TabIndex = 7;
            this.cmbNetMaskDigit2.TextChanged += new System.EventHandler(this.cmbMaskBitSelectedIndexChanged);
            // 
            // cmbNetMaskDigit3
            // 
            this.cmbNetMaskDigit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbNetMaskDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNetMaskDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNetMaskDigit3.FormattingEnabled = true;
            this.cmbNetMaskDigit3.Location = new System.Drawing.Point(328, 82);
            this.cmbNetMaskDigit3.Name = "cmbNetMaskDigit3";
            this.cmbNetMaskDigit3.Size = new System.Drawing.Size(70, 21);
            this.cmbNetMaskDigit3.TabIndex = 8;
            this.cmbNetMaskDigit3.TextChanged += new System.EventHandler(this.cmbMaskBitSelectedIndexChanged);
            // 
            // cmbNetMaskDigit4
            // 
            this.cmbNetMaskDigit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbNetMaskDigit4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbNetMaskDigit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNetMaskDigit4.FormattingEnabled = true;
            this.cmbNetMaskDigit4.Location = new System.Drawing.Point(404, 82);
            this.cmbNetMaskDigit4.Name = "cmbNetMaskDigit4";
            this.cmbNetMaskDigit4.Size = new System.Drawing.Size(70, 21);
            this.cmbNetMaskDigit4.TabIndex = 9;
            this.cmbNetMaskDigit4.TextChanged += new System.EventHandler(this.cmbMaskBitSelectedIndexChanged);
            // 
            // lblNetMaskDigit1
            // 
            this.lblNetMaskDigit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetMaskDigit1.Location = new System.Drawing.Point(176, 106);
            this.lblNetMaskDigit1.Name = "lblNetMaskDigit1";
            this.lblNetMaskDigit1.Size = new System.Drawing.Size(70, 23);
            this.lblNetMaskDigit1.TabIndex = 10;
            // 
            // lblNetMaskDigit2
            // 
            this.lblNetMaskDigit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetMaskDigit2.Location = new System.Drawing.Point(252, 106);
            this.lblNetMaskDigit2.Name = "lblNetMaskDigit2";
            this.lblNetMaskDigit2.Size = new System.Drawing.Size(70, 23);
            this.lblNetMaskDigit2.TabIndex = 11;
            // 
            // lblNetMaskDigit3
            // 
            this.lblNetMaskDigit3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetMaskDigit3.Location = new System.Drawing.Point(328, 106);
            this.lblNetMaskDigit3.Name = "lblNetMaskDigit3";
            this.lblNetMaskDigit3.Size = new System.Drawing.Size(70, 23);
            this.lblNetMaskDigit3.TabIndex = 12;
            // 
            // lblNetMaskDigit4
            // 
            this.lblNetMaskDigit4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetMaskDigit4.Location = new System.Drawing.Point(404, 106);
            this.lblNetMaskDigit4.Name = "lblNetMaskDigit4";
            this.lblNetMaskDigit4.Size = new System.Drawing.Size(70, 23);
            this.lblNetMaskDigit4.TabIndex = 13;
            // 
            // lblNetworkDigit1
            // 
            this.lblNetworkDigit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkDigit1.Location = new System.Drawing.Point(176, 47);
            this.lblNetworkDigit1.Name = "lblNetworkDigit1";
            this.lblNetworkDigit1.Size = new System.Drawing.Size(70, 23);
            this.lblNetworkDigit1.TabIndex = 14;
            // 
            // lblNetworkDigit2
            // 
            this.lblNetworkDigit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkDigit2.Location = new System.Drawing.Point(252, 47);
            this.lblNetworkDigit2.Name = "lblNetworkDigit2";
            this.lblNetworkDigit2.Size = new System.Drawing.Size(70, 23);
            this.lblNetworkDigit2.TabIndex = 15;
            // 
            // lblNetworkDigit3
            // 
            this.lblNetworkDigit3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkDigit3.Location = new System.Drawing.Point(328, 47);
            this.lblNetworkDigit3.Name = "lblNetworkDigit3";
            this.lblNetworkDigit3.Size = new System.Drawing.Size(70, 23);
            this.lblNetworkDigit3.TabIndex = 16;
            // 
            // lblNetworkDigit4
            // 
            this.lblNetworkDigit4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetworkDigit4.Location = new System.Drawing.Point(404, 47);
            this.lblNetworkDigit4.Name = "lblNetworkDigit4";
            this.lblNetworkDigit4.Size = new System.Drawing.Size(70, 23);
            this.lblNetworkDigit4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Network Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Subnet Mask";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHostNumber
            // 
            this.lblHostNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostNumber.Location = new System.Drawing.Point(176, 475);
            this.lblHostNumber.Name = "lblHostNumber";
            this.lblHostNumber.Size = new System.Drawing.Size(82, 23);
            this.lblHostNumber.TabIndex = 22;
            this.lblHostNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Available Host";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHostbit
            // 
            this.lblHostbit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHostbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostbit.Location = new System.Drawing.Point(176, 440);
            this.lblHostbit.Name = "lblHostbit";
            this.lblHostbit.Size = new System.Drawing.Size(82, 23);
            this.lblHostbit.TabIndex = 24;
            this.lblHostbit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "Number of Hostbits (n)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHostbit2
            // 
            this.lblHostbit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHostbit2.Location = new System.Drawing.Point(264, 441);
            this.lblHostbit2.Name = "lblHostbit2";
            this.lblHostbit2.Size = new System.Drawing.Size(100, 23);
            this.lblHostbit2.TabIndex = 26;
            this.lblHostbit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHostNumber2
            // 
            this.lblHostNumber2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHostNumber2.Location = new System.Drawing.Point(264, 475);
            this.lblHostNumber2.Name = "lblHostNumber2";
            this.lblHostNumber2.Size = new System.Drawing.Size(100, 23);
            this.lblHostNumber2.TabIndex = 27;
            this.lblHostNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(578, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "Number of Networkbits";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Network ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFourthNetworkIDBits
            // 
            this.lblFourthNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFourthNetworkIDBits.Location = new System.Drawing.Point(404, 177);
            this.lblFourthNetworkIDBits.Name = "lblFourthNetworkIDBits";
            this.lblFourthNetworkIDBits.Size = new System.Drawing.Size(70, 23);
            this.lblFourthNetworkIDBits.TabIndex = 37;
            // 
            // lblThirdNetworkIDBits
            // 
            this.lblThirdNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblThirdNetworkIDBits.Location = new System.Drawing.Point(328, 177);
            this.lblThirdNetworkIDBits.Name = "lblThirdNetworkIDBits";
            this.lblThirdNetworkIDBits.Size = new System.Drawing.Size(70, 23);
            this.lblThirdNetworkIDBits.TabIndex = 36;
            // 
            // lblSecondNetworkIDBits
            // 
            this.lblSecondNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecondNetworkIDBits.Location = new System.Drawing.Point(252, 177);
            this.lblSecondNetworkIDBits.Name = "lblSecondNetworkIDBits";
            this.lblSecondNetworkIDBits.Size = new System.Drawing.Size(70, 23);
            this.lblSecondNetworkIDBits.TabIndex = 35;
            // 
            // lblFirstNetworkIDBits
            // 
            this.lblFirstNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstNetworkIDBits.Location = new System.Drawing.Point(176, 177);
            this.lblFirstNetworkIDBits.Name = "lblFirstNetworkIDBits";
            this.lblFirstNetworkIDBits.Size = new System.Drawing.Size(70, 23);
            this.lblFirstNetworkIDBits.TabIndex = 34;
            // 
            // lblFourthNetworkID
            // 
            this.lblFourthNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFourthNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourthNetworkID.Location = new System.Drawing.Point(404, 150);
            this.lblFourthNetworkID.Name = "lblFourthNetworkID";
            this.lblFourthNetworkID.Size = new System.Drawing.Size(70, 23);
            this.lblFourthNetworkID.TabIndex = 41;
            this.lblFourthNetworkID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThirdNetworkID
            // 
            this.lblThirdNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThirdNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdNetworkID.Location = new System.Drawing.Point(328, 150);
            this.lblThirdNetworkID.Name = "lblThirdNetworkID";
            this.lblThirdNetworkID.Size = new System.Drawing.Size(70, 23);
            this.lblThirdNetworkID.TabIndex = 40;
            this.lblThirdNetworkID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondNetworkID
            // 
            this.lblSecondNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecondNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNetworkID.Location = new System.Drawing.Point(252, 150);
            this.lblSecondNetworkID.Name = "lblSecondNetworkID";
            this.lblSecondNetworkID.Size = new System.Drawing.Size(70, 23);
            this.lblSecondNetworkID.TabIndex = 39;
            this.lblSecondNetworkID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstNetworkID
            // 
            this.lblFirstNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNetworkID.Location = new System.Drawing.Point(176, 150);
            this.lblFirstNetworkID.Name = "lblFirstNetworkID";
            this.lblFirstNetworkID.Size = new System.Drawing.Size(70, 23);
            this.lblFirstNetworkID.TabIndex = 38;
            this.lblFirstNetworkID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstHost4
            // 
            this.lblFirstHost4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstHost4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstHost4.Location = new System.Drawing.Point(404, 219);
            this.lblFirstHost4.Name = "lblFirstHost4";
            this.lblFirstHost4.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost4.TabIndex = 50;
            this.lblFirstHost4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstHost3
            // 
            this.lblFirstHost3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstHost3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstHost3.Location = new System.Drawing.Point(328, 219);
            this.lblFirstHost3.Name = "lblFirstHost3";
            this.lblFirstHost3.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost3.TabIndex = 49;
            this.lblFirstHost3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstHost2
            // 
            this.lblFirstHost2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstHost2.Location = new System.Drawing.Point(252, 219);
            this.lblFirstHost2.Name = "lblFirstHost2";
            this.lblFirstHost2.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost2.TabIndex = 48;
            this.lblFirstHost2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstHost1
            // 
            this.lblFirstHost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstHost1.Location = new System.Drawing.Point(176, 219);
            this.lblFirstHost1.Name = "lblFirstHost1";
            this.lblFirstHost1.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost1.TabIndex = 47;
            this.lblFirstHost1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstHost4Bits
            // 
            this.lblFirstHost4Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstHost4Bits.Location = new System.Drawing.Point(404, 246);
            this.lblFirstHost4Bits.Name = "lblFirstHost4Bits";
            this.lblFirstHost4Bits.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost4Bits.TabIndex = 46;
            // 
            // lblFirstHost3Bits
            // 
            this.lblFirstHost3Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstHost3Bits.Location = new System.Drawing.Point(328, 246);
            this.lblFirstHost3Bits.Name = "lblFirstHost3Bits";
            this.lblFirstHost3Bits.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost3Bits.TabIndex = 45;
            // 
            // lblFirstHost2Bits
            // 
            this.lblFirstHost2Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstHost2Bits.Location = new System.Drawing.Point(252, 246);
            this.lblFirstHost2Bits.Name = "lblFirstHost2Bits";
            this.lblFirstHost2Bits.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost2Bits.TabIndex = 44;
            // 
            // lblFirstHost1Bits
            // 
            this.lblFirstHost1Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstHost1Bits.Location = new System.Drawing.Point(176, 246);
            this.lblFirstHost1Bits.Name = "lblFirstHost1Bits";
            this.lblFirstHost1Bits.Size = new System.Drawing.Size(70, 23);
            this.lblFirstHost1Bits.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(38, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 21);
            this.label15.TabIndex = 42;
            this.label15.Text = "First Host";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastHost4
            // 
            this.lblLastHost4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastHost4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastHost4.Location = new System.Drawing.Point(404, 287);
            this.lblLastHost4.Name = "lblLastHost4";
            this.lblLastHost4.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost4.TabIndex = 59;
            this.lblLastHost4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastHost3
            // 
            this.lblLastHost3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastHost3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastHost3.Location = new System.Drawing.Point(328, 287);
            this.lblLastHost3.Name = "lblLastHost3";
            this.lblLastHost3.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost3.TabIndex = 58;
            this.lblLastHost3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastHost2
            // 
            this.lblLastHost2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastHost2.Location = new System.Drawing.Point(252, 287);
            this.lblLastHost2.Name = "lblLastHost2";
            this.lblLastHost2.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost2.TabIndex = 57;
            this.lblLastHost2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastHost1
            // 
            this.lblLastHost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastHost1.Location = new System.Drawing.Point(176, 287);
            this.lblLastHost1.Name = "lblLastHost1";
            this.lblLastHost1.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost1.TabIndex = 56;
            this.lblLastHost1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastHost4Bits
            // 
            this.lblLastHost4Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastHost4Bits.Location = new System.Drawing.Point(404, 314);
            this.lblLastHost4Bits.Name = "lblLastHost4Bits";
            this.lblLastHost4Bits.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost4Bits.TabIndex = 55;
            // 
            // lblLastHost3Bits
            // 
            this.lblLastHost3Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastHost3Bits.Location = new System.Drawing.Point(328, 314);
            this.lblLastHost3Bits.Name = "lblLastHost3Bits";
            this.lblLastHost3Bits.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost3Bits.TabIndex = 54;
            // 
            // lblLastHost2Bits
            // 
            this.lblLastHost2Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastHost2Bits.Location = new System.Drawing.Point(252, 314);
            this.lblLastHost2Bits.Name = "lblLastHost2Bits";
            this.lblLastHost2Bits.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost2Bits.TabIndex = 53;
            // 
            // lblLastHost1Bits
            // 
            this.lblLastHost1Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLastHost1Bits.Location = new System.Drawing.Point(176, 314);
            this.lblLastHost1Bits.Name = "lblLastHost1Bits";
            this.lblLastHost1Bits.Size = new System.Drawing.Size(70, 23);
            this.lblLastHost1Bits.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 21);
            this.label16.TabIndex = 51;
            this.label16.Text = "Last Host";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBC_IP4
            // 
            this.lblBC_IP4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBC_IP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBC_IP4.Location = new System.Drawing.Point(404, 353);
            this.lblBC_IP4.Name = "lblBC_IP4";
            this.lblBC_IP4.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP4.TabIndex = 68;
            this.lblBC_IP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBC_IP3
            // 
            this.lblBC_IP3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBC_IP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBC_IP3.Location = new System.Drawing.Point(328, 353);
            this.lblBC_IP3.Name = "lblBC_IP3";
            this.lblBC_IP3.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP3.TabIndex = 67;
            this.lblBC_IP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBC_IP2
            // 
            this.lblBC_IP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBC_IP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBC_IP2.Location = new System.Drawing.Point(252, 353);
            this.lblBC_IP2.Name = "lblBC_IP2";
            this.lblBC_IP2.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP2.TabIndex = 66;
            this.lblBC_IP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBC_IP1
            // 
            this.lblBC_IP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBC_IP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBC_IP1.Location = new System.Drawing.Point(176, 353);
            this.lblBC_IP1.Name = "lblBC_IP1";
            this.lblBC_IP1.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP1.TabIndex = 65;
            this.lblBC_IP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBC_IP4Bits
            // 
            this.lblBC_IP4Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBC_IP4Bits.Location = new System.Drawing.Point(404, 380);
            this.lblBC_IP4Bits.Name = "lblBC_IP4Bits";
            this.lblBC_IP4Bits.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP4Bits.TabIndex = 64;
            // 
            // lblBC_IP3Bits
            // 
            this.lblBC_IP3Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBC_IP3Bits.Location = new System.Drawing.Point(328, 380);
            this.lblBC_IP3Bits.Name = "lblBC_IP3Bits";
            this.lblBC_IP3Bits.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP3Bits.TabIndex = 63;
            // 
            // lblBC_IP2Bits
            // 
            this.lblBC_IP2Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBC_IP2Bits.Location = new System.Drawing.Point(252, 380);
            this.lblBC_IP2Bits.Name = "lblBC_IP2Bits";
            this.lblBC_IP2Bits.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP2Bits.TabIndex = 62;
            // 
            // lblBC_IP1Bits
            // 
            this.lblBC_IP1Bits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBC_IP1Bits.Location = new System.Drawing.Point(176, 380);
            this.lblBC_IP1Bits.Name = "lblBC_IP1Bits";
            this.lblBC_IP1Bits.Size = new System.Drawing.Size(70, 23);
            this.lblBC_IP1Bits.TabIndex = 61;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 354);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 21);
            this.label17.TabIndex = 60;
            this.label17.Text = "Broadcast";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 23);
            this.label7.TabIndex = 69;
            this.label7.Text = "/";
            // 
            // lblMaskBit
            // 
            this.lblMaskBit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaskBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaskBit.Location = new System.Drawing.Point(514, 150);
            this.lblMaskBit.Name = "lblMaskBit";
            this.lblMaskBit.Size = new System.Drawing.Size(27, 23);
            this.lblMaskBit.TabIndex = 70;
            // 
            // lblPublicPrivateIP
            // 
            this.lblPublicPrivateIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicPrivateIP.Location = new System.Drawing.Point(547, 150);
            this.lblPublicPrivateIP.Name = "lblPublicPrivateIP";
            this.lblPublicPrivateIP.Size = new System.Drawing.Size(103, 23);
            this.lblPublicPrivateIP.TabIndex = 71;
            this.lblPublicPrivateIP.Text = "Invisible";
            // 
            // lblFirstDigtZero
            // 
            this.lblFirstDigtZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstDigtZero.Location = new System.Drawing.Point(514, 47);
            this.lblFirstDigtZero.Name = "lblFirstDigtZero";
            this.lblFirstDigtZero.Size = new System.Drawing.Size(107, 23);
            this.lblFirstDigtZero.TabIndex = 72;
            this.lblFirstDigtZero.Text = "Invisible";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 73;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateIPsToolStripMenuItem,
            this.netmaskToolStripMenuItem,
            this.unicastIPv6ToolStripMenuItem,
            this.multicastIPv6ToolStripMenuItem,
            this.anycastIPv6ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // privateIPsToolStripMenuItem
            // 
            this.privateIPsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.xXToolStripMenuItem,
            this.toolStripMenuItem6,
            this.classEToolStripMenuItem});
            this.privateIPsToolStripMenuItem.Name = "privateIPsToolStripMenuItem";
            this.privateIPsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.privateIPsToolStripMenuItem.Text = "Private IPs   (IPv4)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem2.Text = "192.168.0.0 / 16";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem3.Text = "172.16.0.0 / 12";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.ToolStripMenuItem3Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem4.Text = "10.0.0.0 / 8";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem5.Text = "127.0.0.0 / 8  - LOOKBACK ";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.ToolStripMenuItem5Click);
            // 
            // xXToolStripMenuItem
            // 
            this.xXToolStripMenuItem.Name = "xXToolStripMenuItem";
            this.xXToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.xXToolStripMenuItem.Text = "169.254.0.0 / 16  - APIPA";
            this.xXToolStripMenuItem.Click += new System.EventHandler(this.XXToolStripMenuItemClick);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(214, 22);
            this.toolStripMenuItem6.Text = "224.0.0.0 / 4  Class D";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // classEToolStripMenuItem
            // 
            this.classEToolStripMenuItem.Name = "classEToolStripMenuItem";
            this.classEToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.classEToolStripMenuItem.Text = "240.0.0.0 / 4  Class E";
            this.classEToolStripMenuItem.Click += new System.EventHandler(this.classEToolStripMenuItem_Click);
            // 
            // netmaskToolStripMenuItem
            // 
            this.netmaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMask32,
            this.toolMask31,
            this.toolMask30,
            this.toolMask29,
            this.toolMask28,
            this.toolMask27,
            this.toolMask26,
            this.toolMask25,
            this.toolMask24,
            this.toolMask23,
            this.toolMask22,
            this.toolMask21,
            this.toolMask20,
            this.toolMask19,
            this.toolMask18,
            this.toolMask17,
            this.toolMask16,
            this.toolMask15,
            this.toolMask14,
            this.toolMask13,
            this.toolMask12,
            this.toolMask11,
            this.toolMask10,
            this.toolMask09,
            this.toolMask08,
            this.toolMask07,
            this.toolMask06,
            this.toolMask05,
            this.toolMask04,
            this.toolMask03,
            this.toolMask02,
            this.toolMask01});
            this.netmaskToolStripMenuItem.Name = "netmaskToolStripMenuItem";
            this.netmaskToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.netmaskToolStripMenuItem.Text = "Netmask     (IPv4)";
            // 
            // toolMask32
            // 
            this.toolMask32.Name = "toolMask32";
            this.toolMask32.Size = new System.Drawing.Size(178, 22);
            this.toolMask32.Text = "255.255.255.255  /32";
            this.toolMask32.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask31
            // 
            this.toolMask31.Name = "toolMask31";
            this.toolMask31.Size = new System.Drawing.Size(178, 22);
            this.toolMask31.Text = "255.255.255.254  /31";
            this.toolMask31.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask30
            // 
            this.toolMask30.Name = "toolMask30";
            this.toolMask30.Size = new System.Drawing.Size(178, 22);
            this.toolMask30.Text = "255.255.255.252  /30";
            this.toolMask30.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask29
            // 
            this.toolMask29.Name = "toolMask29";
            this.toolMask29.Size = new System.Drawing.Size(178, 22);
            this.toolMask29.Text = "255.255.255.248  /29";
            this.toolMask29.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask28
            // 
            this.toolMask28.Name = "toolMask28";
            this.toolMask28.Size = new System.Drawing.Size(178, 22);
            this.toolMask28.Text = "255.255.255.240  /28";
            this.toolMask28.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask27
            // 
            this.toolMask27.Name = "toolMask27";
            this.toolMask27.Size = new System.Drawing.Size(178, 22);
            this.toolMask27.Text = "255.255.255.224  /27";
            this.toolMask27.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask26
            // 
            this.toolMask26.Name = "toolMask26";
            this.toolMask26.Size = new System.Drawing.Size(178, 22);
            this.toolMask26.Text = "255.255.255.192  /26";
            this.toolMask26.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask25
            // 
            this.toolMask25.Name = "toolMask25";
            this.toolMask25.Size = new System.Drawing.Size(178, 22);
            this.toolMask25.Text = "255.255.255.128  /25";
            this.toolMask25.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask24
            // 
            this.toolMask24.Name = "toolMask24";
            this.toolMask24.Size = new System.Drawing.Size(178, 22);
            this.toolMask24.Text = "255.255.255.0      /24";
            this.toolMask24.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask23
            // 
            this.toolMask23.Name = "toolMask23";
            this.toolMask23.Size = new System.Drawing.Size(178, 22);
            this.toolMask23.Text = "255.255.254.0      /23";
            this.toolMask23.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask22
            // 
            this.toolMask22.Name = "toolMask22";
            this.toolMask22.Size = new System.Drawing.Size(178, 22);
            this.toolMask22.Text = "255.255.252.0      /22";
            this.toolMask22.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask21
            // 
            this.toolMask21.Name = "toolMask21";
            this.toolMask21.Size = new System.Drawing.Size(178, 22);
            this.toolMask21.Text = "255.255.248.0      /21";
            this.toolMask21.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask20
            // 
            this.toolMask20.Name = "toolMask20";
            this.toolMask20.Size = new System.Drawing.Size(178, 22);
            this.toolMask20.Text = "255.255.240.0      /20";
            this.toolMask20.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask19
            // 
            this.toolMask19.Name = "toolMask19";
            this.toolMask19.Size = new System.Drawing.Size(178, 22);
            this.toolMask19.Text = "255.255.224.0      /19";
            this.toolMask19.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask18
            // 
            this.toolMask18.Name = "toolMask18";
            this.toolMask18.Size = new System.Drawing.Size(178, 22);
            this.toolMask18.Text = "255.255.192.0      /18";
            this.toolMask18.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask17
            // 
            this.toolMask17.Name = "toolMask17";
            this.toolMask17.Size = new System.Drawing.Size(178, 22);
            this.toolMask17.Text = "255.255.128.0      /17";
            this.toolMask17.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask16
            // 
            this.toolMask16.Name = "toolMask16";
            this.toolMask16.Size = new System.Drawing.Size(178, 22);
            this.toolMask16.Text = "255.255.0.0         /16";
            this.toolMask16.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask15
            // 
            this.toolMask15.Name = "toolMask15";
            this.toolMask15.Size = new System.Drawing.Size(178, 22);
            this.toolMask15.Text = "255.254.0.0         /15";
            this.toolMask15.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask14
            // 
            this.toolMask14.Name = "toolMask14";
            this.toolMask14.Size = new System.Drawing.Size(178, 22);
            this.toolMask14.Text = "255.252.0.0         /14";
            this.toolMask14.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask13
            // 
            this.toolMask13.Name = "toolMask13";
            this.toolMask13.Size = new System.Drawing.Size(178, 22);
            this.toolMask13.Text = "255.248.0.0         /13";
            this.toolMask13.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask12
            // 
            this.toolMask12.Name = "toolMask12";
            this.toolMask12.Size = new System.Drawing.Size(178, 22);
            this.toolMask12.Text = "255.240.0.0         /12";
            this.toolMask12.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask11
            // 
            this.toolMask11.Name = "toolMask11";
            this.toolMask11.Size = new System.Drawing.Size(178, 22);
            this.toolMask11.Text = "255.224.0.0         /11";
            this.toolMask11.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask10
            // 
            this.toolMask10.Name = "toolMask10";
            this.toolMask10.Size = new System.Drawing.Size(178, 22);
            this.toolMask10.Text = "255.192.0.0         /10";
            this.toolMask10.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask09
            // 
            this.toolMask09.Name = "toolMask09";
            this.toolMask09.Size = new System.Drawing.Size(178, 22);
            this.toolMask09.Text = "255.128.0.0         /9";
            this.toolMask09.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask08
            // 
            this.toolMask08.Name = "toolMask08";
            this.toolMask08.Size = new System.Drawing.Size(178, 22);
            this.toolMask08.Text = "255.0.0.0             /8";
            this.toolMask08.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask07
            // 
            this.toolMask07.Name = "toolMask07";
            this.toolMask07.Size = new System.Drawing.Size(178, 22);
            this.toolMask07.Text = "254.0.0.0             /7";
            this.toolMask07.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask06
            // 
            this.toolMask06.Name = "toolMask06";
            this.toolMask06.Size = new System.Drawing.Size(178, 22);
            this.toolMask06.Text = "252.0.0.0             /6";
            this.toolMask06.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask05
            // 
            this.toolMask05.Name = "toolMask05";
            this.toolMask05.Size = new System.Drawing.Size(178, 22);
            this.toolMask05.Text = "248.0.0.0             /5";
            this.toolMask05.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask04
            // 
            this.toolMask04.Name = "toolMask04";
            this.toolMask04.Size = new System.Drawing.Size(178, 22);
            this.toolMask04.Text = "240.0.0.0             /4";
            this.toolMask04.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask03
            // 
            this.toolMask03.Name = "toolMask03";
            this.toolMask03.Size = new System.Drawing.Size(178, 22);
            this.toolMask03.Text = "224.0.0.0             /3";
            this.toolMask03.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask02
            // 
            this.toolMask02.Name = "toolMask02";
            this.toolMask02.Size = new System.Drawing.Size(178, 22);
            this.toolMask02.Text = "192.0.0.0             /2";
            this.toolMask02.Click += new System.EventHandler(this.changeMasktool);
            // 
            // toolMask01
            // 
            this.toolMask01.Name = "toolMask01";
            this.toolMask01.Size = new System.Drawing.Size(178, 22);
            this.toolMask01.Text = "128.0.0.0             /1";
            this.toolMask01.Click += new System.EventHandler(this.changeMasktool);
            // 
            // unicastIPv6ToolStripMenuItem
            // 
            this.unicastIPv6ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalUnicastAddressToolStripMenuItem,
            this.uniqueLocalUncastAddressToolStripMenuItem,
            this.linkLocalUnicastAddressToolStripMenuItem,
            this.loopbackAddressToolStripMenuItem,
            this.unspecifiedAddressToolStripMenuItem});
            this.unicastIPv6ToolStripMenuItem.Name = "unicastIPv6ToolStripMenuItem";
            this.unicastIPv6ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.unicastIPv6ToolStripMenuItem.Text = "Unicast        (IPv6)";
            // 
            // globalUnicastAddressToolStripMenuItem
            // 
            this.globalUnicastAddressToolStripMenuItem.Name = "globalUnicastAddressToolStripMenuItem";
            this.globalUnicastAddressToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.globalUnicastAddressToolStripMenuItem.Text = "Global Unicast Address";
            this.globalUnicastAddressToolStripMenuItem.Click += new System.EventHandler(this.globalUnicastAddressToolStripMenuItem_Click);
            // 
            // uniqueLocalUncastAddressToolStripMenuItem
            // 
            this.uniqueLocalUncastAddressToolStripMenuItem.Name = "uniqueLocalUncastAddressToolStripMenuItem";
            this.uniqueLocalUncastAddressToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.uniqueLocalUncastAddressToolStripMenuItem.Text = "Unique Local Uncast Address";
            this.uniqueLocalUncastAddressToolStripMenuItem.Click += new System.EventHandler(this.uniqueLocalUncastAddressToolStripMenuItem_Click);
            // 
            // linkLocalUnicastAddressToolStripMenuItem
            // 
            this.linkLocalUnicastAddressToolStripMenuItem.Name = "linkLocalUnicastAddressToolStripMenuItem";
            this.linkLocalUnicastAddressToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.linkLocalUnicastAddressToolStripMenuItem.Text = "Link Local Unicast Address";
            this.linkLocalUnicastAddressToolStripMenuItem.Click += new System.EventHandler(this.linkLocalUnicastAddressToolStripMenuItem_Click);
            // 
            // loopbackAddressToolStripMenuItem
            // 
            this.loopbackAddressToolStripMenuItem.Name = "loopbackAddressToolStripMenuItem";
            this.loopbackAddressToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.loopbackAddressToolStripMenuItem.Text = "Loopback Address            ::1";
            this.loopbackAddressToolStripMenuItem.Click += new System.EventHandler(this.loopbackAddressToolStripMenuItem_Click);
            // 
            // unspecifiedAddressToolStripMenuItem
            // 
            this.unspecifiedAddressToolStripMenuItem.Name = "unspecifiedAddressToolStripMenuItem";
            this.unspecifiedAddressToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.unspecifiedAddressToolStripMenuItem.Text = "Unspecified Address         ::";
            this.unspecifiedAddressToolStripMenuItem.Click += new System.EventHandler(this.unspecifiedAddressToolStripMenuItem_Click);
            // 
            // multicastIPv6ToolStripMenuItem
            // 
            this.multicastIPv6ToolStripMenuItem.Name = "multicastIPv6ToolStripMenuItem";
            this.multicastIPv6ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.multicastIPv6ToolStripMenuItem.Text = "Multicast     (IPv6)";
            // 
            // anycastIPv6ToolStripMenuItem
            // 
            this.anycastIPv6ToolStripMenuItem.Name = "anycastIPv6ToolStripMenuItem";
            this.anycastIPv6ToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.anycastIPv6ToolStripMenuItem.Text = "Anycast       (IPv6)";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabIPv4);
            this.tabControl1.Controls.Add(this.tabIPv6);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 751);
            this.tabControl1.TabIndex = 74;
            // 
            // tabIPv4
            // 
            this.tabIPv4.Controls.Add(this.lbl_broadcast);
            this.tabIPv4.Controls.Add(this.lbl_last);
            this.tabIPv4.Controls.Add(this.lbl_first);
            this.tabIPv4.Controls.Add(this.label9);
            this.tabIPv4.Controls.Add(this.divideNetwork2);
            this.tabIPv4.Controls.Add(this.txtSizeOfNetwork);
            this.tabIPv4.Controls.Add(this.label8);
            this.tabIPv4.Controls.Add(this.lbl_number_of_networks);
            this.tabIPv4.Controls.Add(this.divideNetwork);
            this.tabIPv4.Controls.Add(this.txtNumberOfNetwork);
            this.tabIPv4.Controls.Add(this.label1);
            this.tabIPv4.Controls.Add(this.lblFirstDigtZero);
            this.tabIPv4.Controls.Add(this.firstDigitTXT);
            this.tabIPv4.Controls.Add(this.lblPublicPrivateIP);
            this.tabIPv4.Controls.Add(this.secondDigitTXT);
            this.tabIPv4.Controls.Add(this.lblMaskBit);
            this.tabIPv4.Controls.Add(this.thirdDigitTXT);
            this.tabIPv4.Controls.Add(this.label7);
            this.tabIPv4.Controls.Add(this.fourthDigitTXT);
            this.tabIPv4.Controls.Add(this.lblBC_IP4);
            this.tabIPv4.Controls.Add(this.cmbMaskBit);
            this.tabIPv4.Controls.Add(this.lblBC_IP3);
            this.tabIPv4.Controls.Add(this.netmaskLabel);
            this.tabIPv4.Controls.Add(this.lblBC_IP2);
            this.tabIPv4.Controls.Add(this.cmbNetMaskDigit1);
            this.tabIPv4.Controls.Add(this.lblBC_IP1);
            this.tabIPv4.Controls.Add(this.cmbNetMaskDigit2);
            this.tabIPv4.Controls.Add(this.lblBC_IP4Bits);
            this.tabIPv4.Controls.Add(this.cmbNetMaskDigit3);
            this.tabIPv4.Controls.Add(this.lblBC_IP3Bits);
            this.tabIPv4.Controls.Add(this.cmbNetMaskDigit4);
            this.tabIPv4.Controls.Add(this.lblBC_IP2Bits);
            this.tabIPv4.Controls.Add(this.lblNetMaskDigit1);
            this.tabIPv4.Controls.Add(this.lblBC_IP1Bits);
            this.tabIPv4.Controls.Add(this.lblNetMaskDigit2);
            this.tabIPv4.Controls.Add(this.label17);
            this.tabIPv4.Controls.Add(this.lblNetMaskDigit3);
            this.tabIPv4.Controls.Add(this.lblLastHost4);
            this.tabIPv4.Controls.Add(this.lblNetMaskDigit4);
            this.tabIPv4.Controls.Add(this.lblLastHost3);
            this.tabIPv4.Controls.Add(this.lblNetworkDigit1);
            this.tabIPv4.Controls.Add(this.lblLastHost2);
            this.tabIPv4.Controls.Add(this.lblNetworkDigit2);
            this.tabIPv4.Controls.Add(this.lblLastHost1);
            this.tabIPv4.Controls.Add(this.lblNetworkDigit3);
            this.tabIPv4.Controls.Add(this.lblLastHost4Bits);
            this.tabIPv4.Controls.Add(this.lblNetworkDigit4);
            this.tabIPv4.Controls.Add(this.lblLastHost3Bits);
            this.tabIPv4.Controls.Add(this.label2);
            this.tabIPv4.Controls.Add(this.lblLastHost2Bits);
            this.tabIPv4.Controls.Add(this.lblHostNumber);
            this.tabIPv4.Controls.Add(this.lblLastHost1Bits);
            this.tabIPv4.Controls.Add(this.label5);
            this.tabIPv4.Controls.Add(this.label16);
            this.tabIPv4.Controls.Add(this.lblHostbit);
            this.tabIPv4.Controls.Add(this.lblFirstHost4);
            this.tabIPv4.Controls.Add(this.label3);
            this.tabIPv4.Controls.Add(this.lblFirstHost3);
            this.tabIPv4.Controls.Add(this.lblHostbit2);
            this.tabIPv4.Controls.Add(this.lblFirstHost2);
            this.tabIPv4.Controls.Add(this.lblHostNumber2);
            this.tabIPv4.Controls.Add(this.lblFirstHost1);
            this.tabIPv4.Controls.Add(this.label4);
            this.tabIPv4.Controls.Add(this.lblFirstHost4Bits);
            this.tabIPv4.Controls.Add(this.label6);
            this.tabIPv4.Controls.Add(this.lblFirstHost3Bits);
            this.tabIPv4.Controls.Add(this.lblFirstNetworkIDBits);
            this.tabIPv4.Controls.Add(this.lblFirstHost2Bits);
            this.tabIPv4.Controls.Add(this.lblSecondNetworkIDBits);
            this.tabIPv4.Controls.Add(this.lblFirstHost1Bits);
            this.tabIPv4.Controls.Add(this.lblThirdNetworkIDBits);
            this.tabIPv4.Controls.Add(this.label15);
            this.tabIPv4.Controls.Add(this.lblFourthNetworkIDBits);
            this.tabIPv4.Controls.Add(this.lblFourthNetworkID);
            this.tabIPv4.Controls.Add(this.lblFirstNetworkID);
            this.tabIPv4.Controls.Add(this.lblThirdNetworkID);
            this.tabIPv4.Controls.Add(this.lblSecondNetworkID);
            this.tabIPv4.Location = new System.Drawing.Point(4, 22);
            this.tabIPv4.Name = "tabIPv4";
            this.tabIPv4.Padding = new System.Windows.Forms.Padding(3);
            this.tabIPv4.Size = new System.Drawing.Size(752, 725);
            this.tabIPv4.TabIndex = 0;
            this.tabIPv4.Text = "IPv4";
            this.tabIPv4.UseVisualStyleBackColor = true;
            // 
            // lbl_broadcast
            // 
            this.lbl_broadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_broadcast.Location = new System.Drawing.Point(547, 353);
            this.lbl_broadcast.Name = "lbl_broadcast";
            this.lbl_broadcast.Size = new System.Drawing.Size(103, 23);
            this.lbl_broadcast.TabIndex = 82;
            this.lbl_broadcast.Text = "Invisible";
            // 
            // lbl_last
            // 
            this.lbl_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_last.Location = new System.Drawing.Point(547, 287);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(103, 23);
            this.lbl_last.TabIndex = 81;
            this.lbl_last.Text = "Invisible";
            // 
            // lbl_first
            // 
            this.lbl_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_first.Location = new System.Drawing.Point(547, 219);
            this.lbl_first.Name = "lbl_first";
            this.lbl_first.Size = new System.Drawing.Size(103, 23);
            this.lbl_first.TabIndex = 80;
            this.lbl_first.Text = "Invisible";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Size of Networks";
            // 
            // divideNetwork2
            // 
            this.divideNetwork2.Location = new System.Drawing.Point(30, 655);
            this.divideNetwork2.Name = "divideNetwork2";
            this.divideNetwork2.Size = new System.Drawing.Size(100, 23);
            this.divideNetwork2.TabIndex = 78;
            this.divideNetwork2.Text = "Calculate";
            this.divideNetwork2.UseVisualStyleBackColor = true;
            this.divideNetwork2.Click += new System.EventHandler(this.divideNetwork2_Click);
            // 
            // txtSizeOfNetwork
            // 
            this.txtSizeOfNetwork.Location = new System.Drawing.Point(30, 627);
            this.txtSizeOfNetwork.Name = "txtSizeOfNetwork";
            this.txtSizeOfNetwork.Size = new System.Drawing.Size(100, 20);
            this.txtSizeOfNetwork.TabIndex = 77;
            this.txtSizeOfNetwork.Text = "10";
            this.txtSizeOfNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSizeOfNetwork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Number of Networks";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_number_of_networks
            // 
            this.lbl_number_of_networks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_number_of_networks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number_of_networks.Location = new System.Drawing.Point(176, 507);
            this.lbl_number_of_networks.Name = "lbl_number_of_networks";
            this.lbl_number_of_networks.Size = new System.Drawing.Size(480, 206);
            this.lbl_number_of_networks.TabIndex = 75;
            // 
            // divideNetwork
            // 
            this.divideNetwork.Location = new System.Drawing.Point(30, 565);
            this.divideNetwork.Name = "divideNetwork";
            this.divideNetwork.Size = new System.Drawing.Size(100, 27);
            this.divideNetwork.TabIndex = 74;
            this.divideNetwork.Text = "Calculate";
            this.divideNetwork.UseVisualStyleBackColor = true;
            this.divideNetwork.Click += new System.EventHandler(this.divideNetwork_Click);
            // 
            // txtNumberOfNetwork
            // 
            this.txtNumberOfNetwork.Location = new System.Drawing.Point(30, 539);
            this.txtNumberOfNetwork.Name = "txtNumberOfNetwork";
            this.txtNumberOfNetwork.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOfNetwork.TabIndex = 73;
            this.txtNumberOfNetwork.Text = "10";
            this.txtNumberOfNetwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberOfNetwork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyInteger);
            // 
            // tabIPv6
            // 
            this.tabIPv6.Controls.Add(this.textBox9);
            this.tabIPv6.Controls.Add(this.textBox10);
            this.tabIPv6.Controls.Add(this.textBox11);
            this.tabIPv6.Controls.Add(this.textBox12);
            this.tabIPv6.Controls.Add(this.textBox13);
            this.tabIPv6.Controls.Add(this.textBox14);
            this.tabIPv6.Controls.Add(this.textBox15);
            this.tabIPv6.Controls.Add(this.textBox16);
            this.tabIPv6.Controls.Add(this.textBox1);
            this.tabIPv6.Controls.Add(this.textBox2);
            this.tabIPv6.Controls.Add(this.textBox3);
            this.tabIPv6.Controls.Add(this.textBox4);
            this.tabIPv6.Controls.Add(this.textBox5);
            this.tabIPv6.Controls.Add(this.textBox6);
            this.tabIPv6.Controls.Add(this.textBox7);
            this.tabIPv6.Controls.Add(this.textBox8);
            this.tabIPv6.Controls.Add(this.label10);
            this.tabIPv6.Controls.Add(this.cmb_IPv6MaskBit);
            this.tabIPv6.Controls.Add(this.txtIPv6_8Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_7Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_6Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_5Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_4Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_3Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_2Block);
            this.tabIPv6.Controls.Add(this.txtIPv6_1Block);
            this.tabIPv6.Location = new System.Drawing.Point(4, 22);
            this.tabIPv6.Name = "tabIPv6";
            this.tabIPv6.Padding = new System.Windows.Forms.Padding(3);
            this.tabIPv6.Size = new System.Drawing.Size(752, 725);
            this.tabIPv6.TabIndex = 1;
            this.tabIPv6.Text = "IPv6";
            this.tabIPv6.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(573, 151);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(73, 20);
            this.textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(492, 151);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(73, 20);
            this.textBox10.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(411, 151);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(73, 20);
            this.textBox11.TabIndex = 24;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(330, 151);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(73, 20);
            this.textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(249, 151);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(73, 20);
            this.textBox13.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(168, 151);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(73, 20);
            this.textBox14.TabIndex = 21;
            // 
            // textBox15
            // 
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(87, 151);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(73, 20);
            this.textBox15.TabIndex = 20;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(6, 151);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(73, 20);
            this.textBox16.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(573, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(492, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(411, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(330, 83);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(73, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(249, 83);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(73, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(168, 83);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(87, 83);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(73, 20);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(6, 83);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(73, 20);
            this.textBox8.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(652, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "/";
            // 
            // cmb_IPv6MaskBit
            // 
            this.cmb_IPv6MaskBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_IPv6MaskBit.FormattingEnabled = true;
            this.cmb_IPv6MaskBit.Location = new System.Drawing.Point(681, 16);
            this.cmb_IPv6MaskBit.Name = "cmb_IPv6MaskBit";
            this.cmb_IPv6MaskBit.Size = new System.Drawing.Size(58, 21);
            this.cmb_IPv6MaskBit.TabIndex = 9;
            // 
            // txtIPv6_8Block
            // 
            this.txtIPv6_8Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_8Block.Location = new System.Drawing.Point(573, 18);
            this.txtIPv6_8Block.Name = "txtIPv6_8Block";
            this.txtIPv6_8Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_8Block.TabIndex = 8;
            // 
            // txtIPv6_7Block
            // 
            this.txtIPv6_7Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_7Block.Location = new System.Drawing.Point(492, 18);
            this.txtIPv6_7Block.Name = "txtIPv6_7Block";
            this.txtIPv6_7Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_7Block.TabIndex = 7;
            // 
            // txtIPv6_6Block
            // 
            this.txtIPv6_6Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_6Block.Location = new System.Drawing.Point(411, 18);
            this.txtIPv6_6Block.Name = "txtIPv6_6Block";
            this.txtIPv6_6Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_6Block.TabIndex = 6;
            // 
            // txtIPv6_5Block
            // 
            this.txtIPv6_5Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_5Block.Location = new System.Drawing.Point(330, 18);
            this.txtIPv6_5Block.Name = "txtIPv6_5Block";
            this.txtIPv6_5Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_5Block.TabIndex = 5;
            // 
            // txtIPv6_4Block
            // 
            this.txtIPv6_4Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_4Block.Location = new System.Drawing.Point(249, 18);
            this.txtIPv6_4Block.Name = "txtIPv6_4Block";
            this.txtIPv6_4Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_4Block.TabIndex = 4;
            // 
            // txtIPv6_3Block
            // 
            this.txtIPv6_3Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_3Block.Location = new System.Drawing.Point(168, 18);
            this.txtIPv6_3Block.Name = "txtIPv6_3Block";
            this.txtIPv6_3Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_3Block.TabIndex = 3;
            // 
            // txtIPv6_2Block
            // 
            this.txtIPv6_2Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_2Block.Location = new System.Drawing.Point(87, 18);
            this.txtIPv6_2Block.Name = "txtIPv6_2Block";
            this.txtIPv6_2Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_2Block.TabIndex = 2;
            // 
            // txtIPv6_1Block
            // 
            this.txtIPv6_1Block.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6_1Block.Location = new System.Drawing.Point(6, 18);
            this.txtIPv6_1Block.Name = "txtIPv6_1Block";
            this.txtIPv6_1Block.Size = new System.Drawing.Size(73, 20);
            this.txtIPv6_1Block.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 790);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Subnet Calculator";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabIPv4.ResumeLayout(false);
            this.tabIPv4.PerformLayout();
            this.tabIPv6.ResumeLayout(false);
            this.tabIPv6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabIPv4;
        private System.Windows.Forms.TabPage tabIPv6;
        private System.Windows.Forms.Button divideNetwork;
        private System.Windows.Forms.TextBox txtNumberOfNetwork;
        private System.Windows.Forms.Label lbl_number_of_networks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button divideNetwork2;
        private System.Windows.Forms.TextBox txtSizeOfNetwork;
        private System.Windows.Forms.TextBox txtIPv6_8Block;
        private System.Windows.Forms.TextBox txtIPv6_7Block;
        private System.Windows.Forms.TextBox txtIPv6_6Block;
        private System.Windows.Forms.TextBox txtIPv6_5Block;
        private System.Windows.Forms.TextBox txtIPv6_4Block;
        private System.Windows.Forms.TextBox txtIPv6_3Block;
        private System.Windows.Forms.TextBox txtIPv6_2Block;
        private System.Windows.Forms.TextBox txtIPv6_1Block;
        private System.Windows.Forms.Label lbl_broadcast;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.Label lbl_first;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem classEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unicastIPv6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalUnicastAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uniqueLocalUncastAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLocalUnicastAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopbackAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unspecifiedAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multicastIPv6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anycastIPv6ToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_IPv6MaskBit;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
		}
//	}
//}
