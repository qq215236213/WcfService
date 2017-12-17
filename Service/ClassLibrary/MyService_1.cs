using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class MyService_1 : IMyService_1
	{
		private int _value = int.MinValue;
		public int GetValue()
		{
			Console.WriteLine("会话ID：{0}", OperationContext.Current.SessionId);
			return this._value;
		}

		public void SetValue(int n)
		{
			this._value = n;
			Console.WriteLine("会话ID：{0}", OperationContext.Current.SessionId);
		}

		public MyService_1()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("{0} - 服务被实例化。", DateTime.Now.ToLongTimeString());
		}
		// 在析构函数中也输出信息
		~MyService_1()
		{
			Console.WriteLine("{0} - 服务实例被释放。", DateTime.Now.ToLongTimeString());
			Console.WriteLine("--------------------------------");
		}

	}

	[ServiceContract(SessionMode = SessionMode.Required)]
	public interface IMyService_1
	{
		[OperationContract(IsOneWay = true)]
		void SetValue(int n);

		[OperationContract]
		int GetValue();
	}
}
