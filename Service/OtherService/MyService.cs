using System;
using System.Collections.Generic;
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
	}
	public class MyService : IService
	{
		public int AddInt(int a, int b)
		{
			return a + b;
		}
	}
}
