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
			using(ChannelFactory<ServiceReference2.ICustomService> factory = new ChannelFactory<ServiceReference2.ICustomService>("WSHttpBinding_ICustomService"))
			{
				var client = factory.CreateChannel();

                ArtistInfo info = new ArtistInfo
                {
                    ArtistName = "高级垃圾",
                    CreateTime = new DateTime(2018, 7, 17)
                };

                client.SetWorkerInformation(new ServiceReference2.Worker
                {
                    WorkerAge = 180,
                    WorkerNo = "NB-117",
                    WorkerName = "老妖",
                    WorkerArtist = info
                });
            }

            Console.ReadKey();
		}
	}
}
