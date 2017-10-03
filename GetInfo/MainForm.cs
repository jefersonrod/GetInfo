/*
 * Created by SharpDevelop.
 * User: jrodrigues
 * Date: 03/10/2017
 * Time: 10:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Net;

namespace GetInfo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtGetInfoClick(object sender, EventArgs e)
		{
			GetInfo();
		}
		
		public void GetInfo()
		{
			string hostName = Dns.GetHostName(); //Get Hostname from DNS information
			
			string user = System.Environment.GetEnvironmentVariable("USERNAME"); //Get usrname from environment variables
			IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName()); //Get array of IP addresses from DNS information, only from local Hostname
			StringBuilder iplocal = new StringBuilder(); //start Stringbuilder to read IP array
			
			//loop into IP array
			foreach (IPAddress IPA in localIPs)
	        {
				iplocal.Append(IPA.ToString()); //add IP to string builder
				iplocal.Append(Environment.NewLine); //add jump line to string builder
	        }
			      
	        	
			tbLocalHostname.Text = hostName;
			tbIPAddress.Text = iplocal.ToString();
			tbUser.Text = user;
			
		}
	}
}
