using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceInfo : IServiceInfo
    {
        public void TestMethod()
        {
            int index = OperationContext.Current.IncomingMessageHeaders.FindHeader("header", "http://www.myname.com.cn");
            if(index != -1)
            {
                var hd = OperationContext.Current.IncomingMessageHeaders.GetHeader<HeaderData>(index);
                Console.WriteLine($"收到的表头:{hd.Name}|{hd.Age}");
            }
            else
            {
                Console.WriteLine("no header");
            }
        }
    }
}
