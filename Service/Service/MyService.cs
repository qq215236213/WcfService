using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	public class MyService : IMyService
	{
		public Employee GetAEmployee()
		{
			return new Employee { Age = 20, Name = "jim" };
		}
	}


	[ServiceContract]
	public interface IMyService
	{
		[OperationContract]
		Employee GetAEmployee();
	}
}
