using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
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

			using (ServiceReference4.HelloServiceClient client = new ServiceReference4.HelloServiceClient())
			{
				using(OperationContextScope scope = new OperationContextScope(client.InnerChannel))
				{
					MessageHeader hdUserName = MessageHeader.CreateHeader(MyCustomHeader.HeaderTitle, MyCustomHeader.HeaderNS, "admin");
					OperationContext.Current.OutgoingMessageHeaders.Add(hdUserName);
				}

				// 1、调用带元数据参数和返回值的操作
				Console.WriteLine("\n20和35相加的结果是：{0}", client.AddInt(20, 35));
				// 2、调用带有数据协定的操作
				Student student = client.GetStudent();
				Console.WriteLine("\n学生信息---------------------------");
				Console.WriteLine("姓名：{0}\n年龄：{1}", student.StudentName, student.StudentAge);
				// 3、调用带消息协定的操作
				Console.WriteLine("\n15乘以70的结果是：{0}", client.ComputingNumbers(15, 70, "乘"));


			}

			Console.ReadKey();
		}
	}
}
