using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	/// <summary>
	/// 消息拦截器
	/// </summary>
	public class MyMessageInspector : IClientMessageInspector, IDispatchMessageInspector
	{
		public void AfterReceiveReply(ref Message reply, object correlationState)
		{
			//Console.WriteLine("客户端接收到的回复：\n{0}", reply.ToString());
		}

		public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
		{
			//Console.WriteLine("客户端发送请求前的SOAP消息：\n{0}", request.ToString());
			// 检查验证信息
			var index = request.Headers.FindHeader(MyCustomHeader.HeaderTitle, MyCustomHeader.HeaderNS);
			Console.WriteLine(index);
			if (index != -1)
			{
				var header = request.Headers.GetHeader<string>(index);
				Console.WriteLine(header);
			}
			//string header = request.Headers.GetHeader<string>(MyCustomHeader.HeaderTitle, MyCustomHeader.HeaderNS);
			//if (header == "admin")
			//{
			//	Console.WriteLine("用户名和密码正确。");
			//}
			//else
			//{
			//	throw new Exception("验证失败，滚吧！");
			//}
			return null;
		}

		public void BeforeSendReply(ref Message reply, object correlationState)
		{
			//Console.WriteLine("服务器即将作出以下回复：\n{0}", reply.ToString());
		}

		public object BeforeSendRequest(ref Message request, IClientChannel channel)
		{
			//Console.WriteLine("服务器端：接收到的请求：\n{0}", request.ToString());
			// 插入验证信息
			MessageHeader hdUserName = MessageHeader.CreateHeader(MyCustomHeader.HeaderTitle, MyCustomHeader.HeaderNS, "admin");
			Console.WriteLine("1111");
			request.Headers.Add(hdUserName);
			Console.WriteLine(request);
			return null;
		}
	}
}
