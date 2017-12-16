using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	[MessageContract]
	public class CalculationRequest
	{
		[MessageBodyMember]
		public string Operation { get; set; }
		[MessageBodyMember]
		public int NumberA { get; set; }
		[MessageBodyMember]
		public int NumberB { get; set; }
	}
}
