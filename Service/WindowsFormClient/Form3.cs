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
	public partial class Form3 : Form
	{
		ServiceReference2.MyService_1Client client = null;
		MyCallBack cb = null;
		public Form3()
		{
			InitializeComponent();
			cb = new MyCallBack();
			cb.ValueCallbacked += Cb_ValueCallbacked;
		}

		private void Cb_ValueCallbacked(object sender, int e)
		{
			this.result.Text = e.ToString();
		}

		private void begin_Click(object sender, EventArgs e)
		{
			client = new ServiceReference2.MyService_1Client(new System.ServiceModel.InstanceContext(cb));
			client.CallServiceOp();
			begin.Enabled = false;
			stop.Enabled = true;
		}

		private void stop_Click(object sender, EventArgs e)
		{
			try
			{
				if (client != null)
				{
					client.End();
				}
			}
			catch(Exception ex)
			{
				throw ex;
			}
			
			begin.Enabled = true;
			stop.Enabled = false;
		}
	}
}
