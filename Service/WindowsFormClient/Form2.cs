using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormClient
{
	public partial class Form2 : Form
	{
		//ServiceReference2.MyService_1Client client = null;
		public Form2()
		{
			InitializeComponent();
			//client = new ServiceReference2.MyService_1Client();

			//this.FormClosing += (o, e) => { client.Close(); };

		}

		private void button1_Click(object sender, EventArgs e)
		{
			//int v;
			//if(!int.TryParse(this.textBox1.Text,out v))
			//{
			//	return;
			//}

			//client.SetValue(v);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//int v = client.GetValue();
			//this.textBox2.Text = v.ToString();
		}
	}
}
