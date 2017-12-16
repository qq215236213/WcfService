using ClassLibrary;
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
			//using (ChannelFactory<ServiceReference2.ICustomService> factory = new ChannelFactory<ServiceReference2.ICustomService>("WSHttpBinding_ICustomService"))
			//{
			//	var client = factory.CreateChannel();

			//	ArtistInfo info = new ArtistInfo
			//	{
			//		ArtistName = "高级垃圾",
			//		CreateTime = new DateTime(2018, 7, 17)
			//	};

			//	client.SetWorkerInformation(new ServiceReference2.Worker
			//	{
			//		WorkerAge = 180,
			//		WorkerNo = "NB-117",
			//		WorkerName = "老妖",
			//		WorkerArtist = info
			//	});
			//}

			//using (ChannelFactory<ServiceReference1.IService> factory = new ChannelFactory<ServiceReference1.IService>("BasicHttpBinding_IService"))
			//{
			//	var client = factory.CreateChannel();
				
			//	var result = client.AddIntAsync(1, 2);
			//	Console.WriteLine(result.Result);
			//}

			//using(ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient())
			//{
			//	client.Endpoint.EndpointBehaviors.Add(new MyEndPointBehavior());
			//	var result = client.AddInt(1, 2);
			//	Console.WriteLine(result);
			//}

			using(ServiceReference3.HelloServiceClient client = new ServiceReference3.HelloServiceClient())
			{
				var ret = client.AddInt(1, 3);

				Console.WriteLine(ret);
			}

			Console.ReadKey();
		}
	}
}
