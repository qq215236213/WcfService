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
        public Form4()
        {
            InitializeComponent();
            cb = new ChatCallBack();
            cb.MessageReceived += (sender, e) =>
            {
                var messageContent = new MessageContent();
                messageContent.NickName = e.Nick;
                messageContent.Message = e.Msg;
                messageContent.Time = e.SendTime;
                if(e.Nick == MyNickName)
                {
                    messageContent.IsMe = true;
                }
                else
                {
                    messageContent.IsMe = false;
                }
            };
        }
    }
}
