using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	[MessageContract]
	public class CallResultResponse
	{
		[MessageBodyMember]
		public int ComputedResult { get; set; }
	}
}
