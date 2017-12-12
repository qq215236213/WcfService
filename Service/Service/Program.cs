using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(ServiceInfo)))
            {
                host.Opened += (sender, e) =>
                {
                    Console.WriteLine("服务已启动");
                };

                host.Open();

                Console.Read();
            }
        }
    }
}
