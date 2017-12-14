using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "MP3音频文件|*.jpg";
			if (DialogResult.OK.Equals(openFileDialog1.ShowDialog()))
			{
				this.label1.Text = openFileDialog1.FileName;
				this.label2.Text = "准备就绪。";
			}
		}

		private async void button2_Click(object sender, EventArgs e)
		{
			if (!File.Exists(this.label1.Text))
			{
				return;
			}

			FileStream fs = new FileStream(this.label1.Text, FileMode.Open, FileAccess.Read);
			ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
			this.button2.Enabled = false;
			var res = await client.UpLoadFileAsync(fs);
			this.button2.Enabled = true;
			if (res == true)
				this.label2.Text = "上传完成。";
			fs.Close();

			client.Close();
		}
	}
}
