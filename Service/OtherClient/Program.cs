using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherClient
{
	class Program
	{
		static void Main(string[] args)
		{
			using(ChannelFactory<ServiceReference1.IService> factory = new ChannelFactory<ServiceReference1.IService>("WSHttpBinding_IService"))
			{
				var client = factory.CreateChannel();


			}
		}
	}
}
