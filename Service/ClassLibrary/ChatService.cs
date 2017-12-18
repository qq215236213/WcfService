using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ChatService : IChatService
    {
        public static Dictionary<string, IChatCallBack> ClientCallBacks = new Dictionary<string, IChatCallBack>();
        public void Begin()
        {
            string sessionID = OperationContext.Current.SessionId;
            var cb = OperationContext.Current.GetCallbackChannel<IChatCallBack>();
            ClientCallBacks.Add(sessionID, cb);
        }

        public void End()
        {
            string sessionID = OperationContext.Current.SessionId;
            if (ClientCallBacks.ContainsKey(sessionID))
            {
                ClientCallBacks.Remove(sessionID);
            }
        }

        public void SendMsg(string nick, string msg, DateTime sendTime)
        {
            foreach(var client in ClientCallBacks.Values.ToArray())
            {
                if(client != null)
                {
                    client.SendToClients(nick, msg, sendTime);
                }
            }
        }
    }

    [ServiceContract(CallbackContract = typeof(IChatCallBack),SessionMode = SessionMode.Required)]
    public interface IChatService
    {
        [OperationContract(IsOneWay = true,IsInitiating = true, IsTerminating = false)]
        void Begin();

        [OperationContract(IsOneWay = true)]
        void SendMsg(string nick, string msg, DateTime sendTime);

        [OperationContract(IsOneWay = true,IsInitiating = false,IsTerminating = true)]
        void End();
    }


    public interface IChatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void SendToClients(string nick, string msg, DateTime sendTime);
    }
}
