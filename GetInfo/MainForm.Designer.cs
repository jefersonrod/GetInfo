/*
 * Created by SharpDevelop.
 * User: jrodrigues
 * Date: 03/10/2017
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GetInfo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbHostname;
		private System.Windows.Forms.TextBox tbLocalHostname;
		private System.Windows.Forms.Label lbIPAddress;
		private System.Windows.Forms.TextBox tbIPAddress;
		private System.Windows.Forms.Button btGetInfo;
		private System.Windows.Forms.Label lbUser;
		private System.Windows.Forms.TextBox tbUser;
		
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
			this.lbHostname = new System.Windows.Forms.Label();
			this.tbLocalHostname = new System.Windows.Forms.TextBox();
			this.lbIPAddress = new System.Windows.Forms.Label();
			this.tbIPAddress = new System.Windows.Forms.TextBox();
			this.btGetInfo = new System.Windows.Forms.Button();
			this.lbUser = new System.Windows.Forms.Label();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbHostname
			// 
			this.lbHostname.Location = new System.Drawing.Point(13, 13);
			this.lbHostname.Name = "lbHostname";
			this.lbHostname.Size = new System.Drawing.Size(100, 23);
			this.lbHostname.TabIndex = 0;
			this.lbHostname.Text = "Local Hostname";
			// 
			// tbLocalHostname
			// 
			this.tbLocalHostname.Location = new System.Drawing.Point(120, 13);
			this.tbLocalHostname.Name = "tbLocalHostname";
			this.tbLocalHostname.Size = new System.Drawing.Size(152, 20);
			this.tbLocalHostname.TabIndex = 1;
			// 
			// lbIPAddress
			// 
			this.lbIPAddress.Location = new System.Drawing.Point(12, 94);
			this.lbIPAddress.Name = "lbIPAddress";
			this.lbIPAddress.Size = new System.Drawing.Size(60, 63);
			this.lbIPAddress.TabIndex = 2;
			this.lbIPAddress.Text = "IP Address  - IPv6 and IPv4";
			// 
			// tbIPAddress
			// 
			this.tbIPAddress.Location = new System.Drawing.Point(78, 94);
			this.tbIPAddress.Multiline = true;
			this.tbIPAddress.Name = "tbIPAddress";
			this.tbIPAddress.Size = new System.Drawing.Size(194, 63);
			this.tbIPAddress.TabIndex = 3;
			// 
			// btGetInfo
			// 
			this.btGetInfo.Location = new System.Drawing.Point(187, 226);
			this.btGetInfo.Name = "btGetInfo";
			this.btGetInfo.Size = new System.Drawing.Size(75, 23);
			this.btGetInfo.TabIndex = 4;
			this.btGetInfo.Text = "Get Info";
			this.btGetInfo.UseVisualStyleBackColor = true;
			this.btGetInfo.Click += new System.EventHandler(this.BtGetInfoClick);
			// 
			// lbUser
			// 
			this.lbUser.Location = new System.Drawing.Point(12, 50);
			this.lbUser.Name = "lbUser";
			this.lbUser.Size = new System.Drawing.Size(100, 23);
			this.lbUser.TabIndex = 5;
			this.lbUser.Text = "User";
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(120, 53);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(152, 20);
			this.tbUser.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.lbUser);
			this.Controls.Add(this.btGetInfo);
			this.Controls.Add(this.tbIPAddress);
			this.Controls.Add(this.lbIPAddress);
			this.Controls.Add(this.tbLocalHostname);
			this.Controls.Add(this.lbHostname);
			this.Name = "MainForm";
			this.Text = "GetInfo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
