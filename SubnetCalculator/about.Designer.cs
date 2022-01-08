/*
 * Created by SharpDevelop.
 * User: bayram
 * Date: 10/6/2018
 * Time: 12:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SubnetCalculator
{
	partial class about
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblabout;
		
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
            this.lblabout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblabout
            // 
            this.lblabout.Location = new System.Drawing.Point(12, 9);
            this.lblabout.Name = "lblabout";
            this.lblabout.Size = new System.Drawing.Size(583, 201);
            this.lblabout.TabIndex = 0;
            this.lblabout.Text = "label1";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 221);
            this.Controls.Add(this.lblabout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "about";
            this.Load += new System.EventHandler(this.AboutLoad);
            this.ResumeLayout(false);

		}
	}
}
