using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClient
{
    public class ChatCallBack : ServiceReference3.IChatServiceCallback
    {
        public void SendToClients(string nick, string msg, DateTime sendTime)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 事件
        /// </summary>
        public event EventHandler<CallbackRecEventArgs> MessageReceived;
    }

    public class CallbackRecEventArgs : EventArgs
    {
        string _nick, _msg;
        DateTime _time;

        public CallbackRecEventArgs(string nick,string msg,DateTime time)
        {
            this._nick = nick;
            this._msg = msg;
            this._time = time;
        }

        public string Nick
        {
            get { return this._nick; }
        }

        public string Msg
        {
            get { return this._msg; }
        }

        public DateTime SendTime
        {
            get { return this._time; }
        }
    }
}
