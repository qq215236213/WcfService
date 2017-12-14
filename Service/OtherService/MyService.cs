using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	[ServiceContract]
	public interface IService
	{
		[OperationContract]
		int AddInt(int a, int b);

		[OperationContract]
		bool UpLoadFile(Stream streamInput);
	}
	public class MyService : IService
	{
		public int AddInt(int a, int b)
		{
			return a + b;
		}

		public bool UpLoadFile(Stream streamInput)
		{
			bool isSuccess = false;
			try
			{
				using(var outputStream = new FileStream("haha.jpg", FileMode.OpenOrCreate, FileAccess.Write))
				{
					streamInput.CopyTo(outputStream);
					outputStream.Flush();
					isSuccess = true;
					Console.WriteLine("在{0}接收到客户端发送的流，已保存到haha.jpg。", DateTime.Now.ToLongTimeString());
				}
			}
			catch(Exception ex)
			{
				isSuccess = false;
			}


			return isSuccess;
		}
	}
}
