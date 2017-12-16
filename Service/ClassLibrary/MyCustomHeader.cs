using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	[MessageContract]
	public class MyCustomHeader
	{
		[MessageHeader]
		public static string HeaderTitle = "head";
		[MessageHeader]
		public static string HeaderNS = "www.haha.com.cn";
	}
}
