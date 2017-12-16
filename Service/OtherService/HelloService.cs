using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	public class HelloService : IHelloService
	{
		public int AddInt(int a, int b)
		{
			return a + b;
		}

		public CallResultResponse ComputingNumbers(CalculationRequest inMsg)
		{
			CallResultResponse rmsg = new CallResultResponse();
			switch (inMsg.Operation)
			{
				case "加":
					rmsg.ComputedResult = inMsg.NumberA + inMsg.NumberB;
					break;
				case "减":
					rmsg.ComputedResult = inMsg.NumberA - inMsg.NumberB;
					break;
				case "乘":
					rmsg.ComputedResult = inMsg.NumberA * inMsg.NumberB;
					break;
				case "除":
					rmsg.ComputedResult = inMsg.NumberA / inMsg.NumberB;
					break;
				default:
					throw new ArgumentException("运算操作只允许加、减、乘、除。");
			}


			return rmsg;
		}

		public Student GetStudent()
		{
			Student stu = new Student();
			stu.StudentName = "小明";
			stu.StudentAge = 22;
			return stu;
		}
	}


	[ServiceContract]
	public interface IHelloService
	{
		[OperationContract]
		int AddInt(int a, int b);
		[OperationContract]
		Student GetStudent();
		[OperationContract]
		CallResultResponse ComputingNumbers(CalculationRequest inMsg);
	}
}
