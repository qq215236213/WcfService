using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class MyService_1 : IMyService_1
	{
		private int _value = int.MinValue;
		private ICallBack _callBack;
		private Timer timer = null;
		private Random rnd = null;


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

		public void CallServiceOp()
		{
			this._callBack = OperationContext.Current.GetCallbackChannel<ICallBack>();
			this.rnd = new Random();
			timer = new Timer((obj) => _callBack.CallClient(rnd.Next()), null, 10, 3000);
		}

		public void End()
		{
			Console.WriteLine("回话结束，哈哈");
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

	[ServiceContract(SessionMode = SessionMode.Required,CallbackContract = typeof(ICallBack))]
	public interface IMyService_1
	{
		[OperationContract(IsOneWay = true)]
		void SetValue(int n);

		[OperationContract]
		int GetValue();

		[OperationContract(IsOneWay = true/* 必须 */, IsInitiating = true/* 启动会话 */, IsTerminating = false)]
		void CallServiceOp();

		[OperationContract(IsOneWay = true/* 使用回调，必须为OneWay */)]//, IsTerminating = true/* 该操作标识会话终止 */, IsInitiating = false)]
		void End();
	}

	public interface ICallBack
	{
		[OperationContract(IsOneWay = true)]
		void CallClient(int v);
	}
}
