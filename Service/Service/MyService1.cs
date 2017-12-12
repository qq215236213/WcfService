using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public class MyService1 : IMyService1
	{
		public Student GetStudentInfo()
		{
			Student stu = new Student
			{
				Address = new AddrInfo
				{
					City = "杭州市",
					DetailAddr = "西湖科技园",
					Province = "浙江省"
				},
				Name = "张三",
				Phone = "123456789"
			};

			return stu;
		}
	}

	[ServiceContract]
	public interface IMyService1
	{
		[OperationContract]
		Student GetStudentInfo();
	}
}
