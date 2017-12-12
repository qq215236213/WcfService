using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new ServiceHost(typeof(MyService));

			host.Opened += (sender, e) => {
				Console.WriteLine("服务已启动");
			};

			host.Open();

			Console.ReadKey();

			host.Close();
		}
	}
}
