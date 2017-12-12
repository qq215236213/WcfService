using Client.wcf;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ChannelFactory<wcf.IServiceInfo> factory = new ChannelFactory<wcf.IServiceInfo>("BasicHttpBinding_IServiceInfo"))
            {
                var client = factory.CreateChannel();
                using(OperationContextScope scope = new OperationContextScope(client as IClientChannel))
                {
                    MessageHeader myHeader = MessageHeader.CreateHeader("header", "http://www.myname.com.cn", new HeaderData { Name = "jim", Age = 21 });
                    OperationContext.Current.OutgoingMessageHeaders.Add(myHeader);

                    client.TestMethod();
                }
            }
        }
    }
    
}
