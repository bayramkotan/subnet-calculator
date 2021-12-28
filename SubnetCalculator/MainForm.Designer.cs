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
			this.SuspendLayout();
			// 
			// firstDigitTXT
			// 
			this.firstDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.firstDigitTXT.Location = new System.Drawing.Point(135, 33);
			this.firstDigitTXT.Name = "firstDigitTXT";
			this.firstDigitTXT.Size = new System.Drawing.Size(70, 20);
			this.firstDigitTXT.TabIndex = 0;
			this.firstDigitTXT.TextChanged += new System.EventHandler(this.FirstDigitTXTTextChanged);
			// 
			// secondDigitTXT
			// 
			this.secondDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondDigitTXT.Location = new System.Drawing.Point(211, 32);
			this.secondDigitTXT.Name = "secondDigitTXT";
			this.secondDigitTXT.Size = new System.Drawing.Size(70, 20);
			this.secondDigitTXT.TabIndex = 1;
			this.secondDigitTXT.TextChanged += new System.EventHandler(this.SecondDigitTXTTextChanged);
			// 
			// thirdDigitTXT
			// 
			this.thirdDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.thirdDigitTXT.Location = new System.Drawing.Point(287, 32);
			this.thirdDigitTXT.Name = "thirdDigitTXT";
			this.thirdDigitTXT.Size = new System.Drawing.Size(70, 20);
			this.thirdDigitTXT.TabIndex = 2;
			this.thirdDigitTXT.TextChanged += new System.EventHandler(this.ThirdDigitTXTTextChanged);
			// 
			// fourthDigitTXT
			// 
			this.fourthDigitTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fourthDigitTXT.Location = new System.Drawing.Point(363, 32);
			this.fourthDigitTXT.Name = "fourthDigitTXT";
			this.fourthDigitTXT.Size = new System.Drawing.Size(70, 20);
			this.fourthDigitTXT.TabIndex = 3;
			this.fourthDigitTXT.TextChanged += new System.EventHandler(this.FourthDigitTXTTextChanged);
			// 
			// cmbMaskBit
			// 
			this.cmbMaskBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMaskBit.FormattingEnabled = true;
			this.cmbMaskBit.Location = new System.Drawing.Point(473, 31);
			this.cmbMaskBit.Name = "cmbMaskBit";
			this.cmbMaskBit.Size = new System.Drawing.Size(58, 21);
			this.cmbMaskBit.TabIndex = 4;
			this.cmbMaskBit.SelectedIndexChanged += new System.EventHandler(this.cmbMaskBitSelectedIndexChanged);
			this.cmbMaskBit.TextChanged += new System.EventHandler(this.CmbMaskBitTextChanged);
			// 
			// netmaskLabel
			// 
			this.netmaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.netmaskLabel.Location = new System.Drawing.Point(444, 32);
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
			this.cmbNetMaskDigit1.Location = new System.Drawing.Point(135, 91);
			this.cmbNetMaskDigit1.Name = "cmbNetMaskDigit1";
			this.cmbNetMaskDigit1.Size = new System.Drawing.Size(70, 21);
			this.cmbNetMaskDigit1.TabIndex = 6;
			// 
			// cmbNetMaskDigit2
			// 
			this.cmbNetMaskDigit2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.cmbNetMaskDigit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbNetMaskDigit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbNetMaskDigit2.FormattingEnabled = true;
			this.cmbNetMaskDigit2.Location = new System.Drawing.Point(211, 91);
			this.cmbNetMaskDigit2.Name = "cmbNetMaskDigit2";
			this.cmbNetMaskDigit2.Size = new System.Drawing.Size(70, 21);
			this.cmbNetMaskDigit2.TabIndex = 7;
			// 
			// cmbNetMaskDigit3
			// 
			this.cmbNetMaskDigit3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.cmbNetMaskDigit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbNetMaskDigit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbNetMaskDigit3.FormattingEnabled = true;
			this.cmbNetMaskDigit3.Location = new System.Drawing.Point(287, 91);
			this.cmbNetMaskDigit3.Name = "cmbNetMaskDigit3";
			this.cmbNetMaskDigit3.Size = new System.Drawing.Size(70, 21);
			this.cmbNetMaskDigit3.TabIndex = 8;
			// 
			// cmbNetMaskDigit4
			// 
			this.cmbNetMaskDigit4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.cmbNetMaskDigit4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cmbNetMaskDigit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbNetMaskDigit4.FormattingEnabled = true;
			this.cmbNetMaskDigit4.Location = new System.Drawing.Point(363, 91);
			this.cmbNetMaskDigit4.Name = "cmbNetMaskDigit4";
			this.cmbNetMaskDigit4.Size = new System.Drawing.Size(70, 21);
			this.cmbNetMaskDigit4.TabIndex = 9;
			this.cmbNetMaskDigit4.SelectedIndexChanged += new System.EventHandler(this.CmbNetMaskDigit4SelectedIndexChanged);
			// 
			// lblNetMaskDigit1
			// 
			this.lblNetMaskDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetMaskDigit1.Location = new System.Drawing.Point(135, 115);
			this.lblNetMaskDigit1.Name = "lblNetMaskDigit1";
			this.lblNetMaskDigit1.Size = new System.Drawing.Size(70, 23);
			this.lblNetMaskDigit1.TabIndex = 10;
			// 
			// lblNetMaskDigit2
			// 
			this.lblNetMaskDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetMaskDigit2.Location = new System.Drawing.Point(211, 115);
			this.lblNetMaskDigit2.Name = "lblNetMaskDigit2";
			this.lblNetMaskDigit2.Size = new System.Drawing.Size(70, 23);
			this.lblNetMaskDigit2.TabIndex = 11;
			// 
			// lblNetMaskDigit3
			// 
			this.lblNetMaskDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetMaskDigit3.Location = new System.Drawing.Point(287, 115);
			this.lblNetMaskDigit3.Name = "lblNetMaskDigit3";
			this.lblNetMaskDigit3.Size = new System.Drawing.Size(70, 23);
			this.lblNetMaskDigit3.TabIndex = 12;
			// 
			// lblNetMaskDigit4
			// 
			this.lblNetMaskDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetMaskDigit4.Location = new System.Drawing.Point(363, 115);
			this.lblNetMaskDigit4.Name = "lblNetMaskDigit4";
			this.lblNetMaskDigit4.Size = new System.Drawing.Size(70, 23);
			this.lblNetMaskDigit4.TabIndex = 13;
			// 
			// lblNetworkDigit1
			// 
			this.lblNetworkDigit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetworkDigit1.Location = new System.Drawing.Point(135, 56);
			this.lblNetworkDigit1.Name = "lblNetworkDigit1";
			this.lblNetworkDigit1.Size = new System.Drawing.Size(70, 23);
			this.lblNetworkDigit1.TabIndex = 14;
			// 
			// lblNetworkDigit2
			// 
			this.lblNetworkDigit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetworkDigit2.Location = new System.Drawing.Point(211, 56);
			this.lblNetworkDigit2.Name = "lblNetworkDigit2";
			this.lblNetworkDigit2.Size = new System.Drawing.Size(70, 23);
			this.lblNetworkDigit2.TabIndex = 15;
			// 
			// lblNetworkDigit3
			// 
			this.lblNetworkDigit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetworkDigit3.Location = new System.Drawing.Point(287, 56);
			this.lblNetworkDigit3.Name = "lblNetworkDigit3";
			this.lblNetworkDigit3.Size = new System.Drawing.Size(70, 23);
			this.lblNetworkDigit3.TabIndex = 16;
			// 
			// lblNetworkDigit4
			// 
			this.lblNetworkDigit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNetworkDigit4.Location = new System.Drawing.Point(363, 56);
			this.lblNetworkDigit4.Name = "lblNetworkDigit4";
			this.lblNetworkDigit4.Size = new System.Drawing.Size(70, 23);
			this.lblNetworkDigit4.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 21);
			this.label1.TabIndex = 18;
			this.label1.Text = "Network Address";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 21);
			this.label2.TabIndex = 19;
			this.label2.Text = "Subnet Mask";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHostNumber
			// 
			this.lblHostNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHostNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHostNumber.Location = new System.Drawing.Point(135, 456);
			this.lblHostNumber.Name = "lblHostNumber";
			this.lblHostNumber.Size = new System.Drawing.Size(82, 23);
			this.lblHostNumber.TabIndex = 22;
			this.lblHostNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 456);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 21);
			this.label5.TabIndex = 23;
			this.label5.Text = "Available Host";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHostbit
			// 
			this.lblHostbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHostbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHostbit.Location = new System.Drawing.Point(135, 421);
			this.lblHostbit.Name = "lblHostbit";
			this.lblHostbit.Size = new System.Drawing.Size(82, 23);
			this.lblHostbit.TabIndex = 24;
			this.lblHostbit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 412);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 33);
			this.label3.TabIndex = 25;
			this.label3.Text = "Number of Hostbits (n)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHostbit2
			// 
			this.lblHostbit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHostbit2.Location = new System.Drawing.Point(223, 422);
			this.lblHostbit2.Name = "lblHostbit2";
			this.lblHostbit2.Size = new System.Drawing.Size(100, 23);
			this.lblHostbit2.TabIndex = 26;
			this.lblHostbit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblHostNumber2
			// 
			this.lblHostNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblHostNumber2.Location = new System.Drawing.Point(223, 456);
			this.lblHostNumber2.Name = "lblHostNumber2";
			this.lblHostNumber2.Size = new System.Drawing.Size(100, 23);
			this.lblHostNumber2.TabIndex = 27;
			this.lblHostNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(537, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 33);
			this.label4.TabIndex = 28;
			this.label4.Text = "Number of Networkbits";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 161);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 21);
			this.label6.TabIndex = 29;
			this.label6.Text = "Network ID";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFourthNetworkIDBits
			// 
			this.lblFourthNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFourthNetworkIDBits.Location = new System.Drawing.Point(363, 186);
			this.lblFourthNetworkIDBits.Name = "lblFourthNetworkIDBits";
			this.lblFourthNetworkIDBits.Size = new System.Drawing.Size(70, 23);
			this.lblFourthNetworkIDBits.TabIndex = 37;
			// 
			// lblThirdNetworkIDBits
			// 
			this.lblThirdNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblThirdNetworkIDBits.Location = new System.Drawing.Point(287, 186);
			this.lblThirdNetworkIDBits.Name = "lblThirdNetworkIDBits";
			this.lblThirdNetworkIDBits.Size = new System.Drawing.Size(70, 23);
			this.lblThirdNetworkIDBits.TabIndex = 36;
			// 
			// lblSecondNetworkIDBits
			// 
			this.lblSecondNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSecondNetworkIDBits.Location = new System.Drawing.Point(211, 186);
			this.lblSecondNetworkIDBits.Name = "lblSecondNetworkIDBits";
			this.lblSecondNetworkIDBits.Size = new System.Drawing.Size(70, 23);
			this.lblSecondNetworkIDBits.TabIndex = 35;
			// 
			// lblFirstNetworkIDBits
			// 
			this.lblFirstNetworkIDBits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstNetworkIDBits.Location = new System.Drawing.Point(135, 186);
			this.lblFirstNetworkIDBits.Name = "lblFirstNetworkIDBits";
			this.lblFirstNetworkIDBits.Size = new System.Drawing.Size(70, 23);
			this.lblFirstNetworkIDBits.TabIndex = 34;
			// 
			// lblFourthNetworkID
			// 
			this.lblFourthNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFourthNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFourthNetworkID.Location = new System.Drawing.Point(363, 159);
			this.lblFourthNetworkID.Name = "lblFourthNetworkID";
			this.lblFourthNetworkID.Size = new System.Drawing.Size(70, 23);
			this.lblFourthNetworkID.TabIndex = 41;
			// 
			// lblThirdNetworkID
			// 
			this.lblThirdNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblThirdNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblThirdNetworkID.Location = new System.Drawing.Point(287, 159);
			this.lblThirdNetworkID.Name = "lblThirdNetworkID";
			this.lblThirdNetworkID.Size = new System.Drawing.Size(70, 23);
			this.lblThirdNetworkID.TabIndex = 40;
			// 
			// lblSecondNetworkID
			// 
			this.lblSecondNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSecondNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSecondNetworkID.Location = new System.Drawing.Point(211, 159);
			this.lblSecondNetworkID.Name = "lblSecondNetworkID";
			this.lblSecondNetworkID.Size = new System.Drawing.Size(70, 23);
			this.lblSecondNetworkID.TabIndex = 39;
			// 
			// lblFirstNetworkID
			// 
			this.lblFirstNetworkID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstNetworkID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstNetworkID.Location = new System.Drawing.Point(135, 159);
			this.lblFirstNetworkID.Name = "lblFirstNetworkID";
			this.lblFirstNetworkID.Size = new System.Drawing.Size(70, 23);
			this.lblFirstNetworkID.TabIndex = 38;
			// 
			// lblFirstHost4
			// 
			this.lblFirstHost4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstHost4.Location = new System.Drawing.Point(363, 228);
			this.lblFirstHost4.Name = "lblFirstHost4";
			this.lblFirstHost4.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost4.TabIndex = 50;
			// 
			// lblFirstHost3
			// 
			this.lblFirstHost3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstHost3.Location = new System.Drawing.Point(287, 228);
			this.lblFirstHost3.Name = "lblFirstHost3";
			this.lblFirstHost3.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost3.TabIndex = 49;
			// 
			// lblFirstHost2
			// 
			this.lblFirstHost2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstHost2.Location = new System.Drawing.Point(211, 228);
			this.lblFirstHost2.Name = "lblFirstHost2";
			this.lblFirstHost2.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost2.TabIndex = 48;
			// 
			// lblFirstHost1
			// 
			this.lblFirstHost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstHost1.Location = new System.Drawing.Point(135, 228);
			this.lblFirstHost1.Name = "lblFirstHost1";
			this.lblFirstHost1.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost1.TabIndex = 47;
			// 
			// lblFirstHost4Bits
			// 
			this.lblFirstHost4Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost4Bits.Location = new System.Drawing.Point(363, 255);
			this.lblFirstHost4Bits.Name = "lblFirstHost4Bits";
			this.lblFirstHost4Bits.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost4Bits.TabIndex = 46;
			// 
			// lblFirstHost3Bits
			// 
			this.lblFirstHost3Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost3Bits.Location = new System.Drawing.Point(287, 255);
			this.lblFirstHost3Bits.Name = "lblFirstHost3Bits";
			this.lblFirstHost3Bits.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost3Bits.TabIndex = 45;
			// 
			// lblFirstHost2Bits
			// 
			this.lblFirstHost2Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost2Bits.Location = new System.Drawing.Point(211, 255);
			this.lblFirstHost2Bits.Name = "lblFirstHost2Bits";
			this.lblFirstHost2Bits.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost2Bits.TabIndex = 44;
			// 
			// lblFirstHost1Bits
			// 
			this.lblFirstHost1Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFirstHost1Bits.Location = new System.Drawing.Point(135, 255);
			this.lblFirstHost1Bits.Name = "lblFirstHost1Bits";
			this.lblFirstHost1Bits.Size = new System.Drawing.Size(70, 23);
			this.lblFirstHost1Bits.TabIndex = 43;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(25, 230);
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
			this.lblLastHost4.Location = new System.Drawing.Point(363, 296);
			this.lblLastHost4.Name = "lblLastHost4";
			this.lblLastHost4.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost4.TabIndex = 59;
			// 
			// lblLastHost3
			// 
			this.lblLastHost3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastHost3.Location = new System.Drawing.Point(287, 296);
			this.lblLastHost3.Name = "lblLastHost3";
			this.lblLastHost3.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost3.TabIndex = 58;
			// 
			// lblLastHost2
			// 
			this.lblLastHost2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastHost2.Location = new System.Drawing.Point(211, 296);
			this.lblLastHost2.Name = "lblLastHost2";
			this.lblLastHost2.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost2.TabIndex = 57;
			// 
			// lblLastHost1
			// 
			this.lblLastHost1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastHost1.Location = new System.Drawing.Point(135, 296);
			this.lblLastHost1.Name = "lblLastHost1";
			this.lblLastHost1.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost1.TabIndex = 56;
			// 
			// lblLastHost4Bits
			// 
			this.lblLastHost4Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost4Bits.Location = new System.Drawing.Point(363, 323);
			this.lblLastHost4Bits.Name = "lblLastHost4Bits";
			this.lblLastHost4Bits.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost4Bits.TabIndex = 55;
			// 
			// lblLastHost3Bits
			// 
			this.lblLastHost3Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost3Bits.Location = new System.Drawing.Point(287, 323);
			this.lblLastHost3Bits.Name = "lblLastHost3Bits";
			this.lblLastHost3Bits.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost3Bits.TabIndex = 54;
			// 
			// lblLastHost2Bits
			// 
			this.lblLastHost2Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost2Bits.Location = new System.Drawing.Point(211, 323);
			this.lblLastHost2Bits.Name = "lblLastHost2Bits";
			this.lblLastHost2Bits.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost2Bits.TabIndex = 53;
			// 
			// lblLastHost1Bits
			// 
			this.lblLastHost1Bits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLastHost1Bits.Location = new System.Drawing.Point(135, 323);
			this.lblLastHost1Bits.Name = "lblLastHost1Bits";
			this.lblLastHost1Bits.Size = new System.Drawing.Size(70, 23);
			this.lblLastHost1Bits.TabIndex = 52;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(25, 298);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(104, 21);
			this.label16.TabIndex = 51;
			this.label16.Text = "Last Host";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 504);
			this.Controls.Add(this.lblLastHost4);
			this.Controls.Add(this.lblLastHost3);
			this.Controls.Add(this.lblLastHost2);
			this.Controls.Add(this.lblLastHost1);
			this.Controls.Add(this.lblLastHost4Bits);
			this.Controls.Add(this.lblLastHost3Bits);
			this.Controls.Add(this.lblLastHost2Bits);
			this.Controls.Add(this.lblLastHost1Bits);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.lblFirstHost4);
			this.Controls.Add(this.lblFirstHost3);
			this.Controls.Add(this.lblFirstHost2);
			this.Controls.Add(this.lblFirstHost1);
			this.Controls.Add(this.lblFirstHost4Bits);
			this.Controls.Add(this.lblFirstHost3Bits);
			this.Controls.Add(this.lblFirstHost2Bits);
			this.Controls.Add(this.lblFirstHost1Bits);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.lblFourthNetworkID);
			this.Controls.Add(this.lblThirdNetworkID);
			this.Controls.Add(this.lblSecondNetworkID);
			this.Controls.Add(this.lblFirstNetworkID);
			this.Controls.Add(this.lblFourthNetworkIDBits);
			this.Controls.Add(this.lblThirdNetworkIDBits);
			this.Controls.Add(this.lblSecondNetworkIDBits);
			this.Controls.Add(this.lblFirstNetworkIDBits);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblHostNumber2);
			this.Controls.Add(this.lblHostbit2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblHostbit);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblHostNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblNetworkDigit4);
			this.Controls.Add(this.lblNetworkDigit3);
			this.Controls.Add(this.lblNetworkDigit2);
			this.Controls.Add(this.lblNetworkDigit1);
			this.Controls.Add(this.lblNetMaskDigit4);
			this.Controls.Add(this.lblNetMaskDigit3);
			this.Controls.Add(this.lblNetMaskDigit2);
			this.Controls.Add(this.lblNetMaskDigit1);
			this.Controls.Add(this.cmbNetMaskDigit4);
			this.Controls.Add(this.cmbNetMaskDigit3);
			this.Controls.Add(this.cmbNetMaskDigit2);
			this.Controls.Add(this.cmbNetMaskDigit1);
			this.Controls.Add(this.netmaskLabel);
			this.Controls.Add(this.cmbMaskBit);
			this.Controls.Add(this.fourthDigitTXT);
			this.Controls.Add(this.thirdDigitTXT);
			this.Controls.Add(this.secondDigitTXT);
			this.Controls.Add(this.firstDigitTXT);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Subnet Calculator";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.TextChanged += new System.EventHandler(this.MainFormTextChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		}
	}
//}
