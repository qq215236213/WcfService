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
    public partial class Form4 : Form
    {
        private ChatCallBack cb = null;
        private string MyNickName = string.Empty;
		private ServiceReference3.ChatServiceClient client = null;
        public Form4()
        {
            InitializeComponent();
            cb = new ChatCallBack();
			client = new ServiceReference3.ChatServiceClient(new System.ServiceModel.InstanceContext(cb));
			client.Begin();
			cb.MessageReceived += (sender, e) =>
            {
                //var messageContent = new MessageContent();
                //messageContent.NickName = e.Nick;
                //messageContent.Message = e.Msg;
                //messageContent.Time = e.SendTime;
                //if(e.Nick == MyNickName)
                //{
                //    messageContent.IsMe = true;
                //}
                //else
                //{
                //    messageContent.IsMe = false;
                //}
				var text = new StringBuilder();
				text.Append(e.Nick + "   " + e.SendTime.ToString("yyyy-MM-dd"));
				text.AppendLine();
				text.AppendLine(e.Msg);
				this.displaymsg.AppendText(text.ToString());
            };

			this.FormClosing += (sender, e) =>
			{
				client.End();
				//client.Close();
			};
        }

		private void btnsend_Click(object sender, EventArgs e)
		{
			client.SendMsg(this.nickname.Text, this.sendmsg.Text, DateTime.Now);
			this.sendmsg.Clear();
			this.resultmsg.Text = "發送成功";
		}
	}
}
