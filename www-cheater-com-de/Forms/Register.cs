using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace www_cheater_com_de.Forms
{
	public partial class Register : Form
	{
		public Register(string daysLeft)
		{
			InitializeComponent();
			registrationMessage.Text = daysLeft;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var macAddr =
	(
		from nic in NetworkInterface.GetAllNetworkInterfaces()
		where nic.OperationalStatus == OperationalStatus.Up
		select nic.GetPhysicalAddress().ToString()
	).FirstOrDefault();
				Process.Start("http://www.cheater.com.de/register.php?id=" + macAddr);
			}
			catch (Exception netexc)
			{

			}
			
		}

		private void Register_Load(object sender, EventArgs e)
		{

		}
	}
}
