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
			//using(ChannelFactory<wcf.IServiceInfo> factory = new ChannelFactory<wcf.IServiceInfo>("BasicHttpBinding_IServiceInfo"))
			//{
			//    var client = factory.CreateChannel();
			//    using(OperationContextScope scope = new OperationContextScope(client as IClientChannel))
			//    {
			//        MessageHeader myHeader = MessageHeader.CreateHeader("header", "http://www.myname.com.cn", new HeaderData { Name = "jim", Age = 21 });
			//        OperationContext.Current.OutgoingMessageHeaders.Add(myHeader);

			//        client.TestMethod();
			//    }
			//}

			//using(ChannelFactory<wcfservice.IMyService> factory = new ChannelFactory<wcfservice.IMyService>("NetTcpBinding_IMyService"))
			//{
			//	var client = factory.CreateChannel();
			//	var em = client.GetAEmployee();

			//	Console.WriteLine($"员工信息\n姓名：{em.Name}\n年龄：{em.Age}");

			//	Console.Read();
			//}

			using (ChannelFactory<ServiceRef.IMyService1> factory = new ChannelFactory<ServiceRef.IMyService1>("NetTcpBinding_IMyService1"))
			{
				var client = factory.CreateChannel();
				var stu = client.GetStudentInfo();

				string msg = "学生姓名：{0}\n联系电话：{1}\n" +
						"地址信息：-----------\n" +
						"省份：{2}\n" +
						"市区：{3}\n" +
						"详细地址：{4}";
				Console.WriteLine(msg, stu.Name, stu.Phone, stu.Address.Province, stu.Address.City, stu.Address.DetailAddr);

				Console.Read();
			}
        }
    }
    
}
