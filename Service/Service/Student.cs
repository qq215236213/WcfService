using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	[DataContract]
	public class Student
	{
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string Phone { get; set; }
		[DataMember]
		public AddrInfo Address { get; set; }
	}

	[DataContract]
	public class AddrInfo
	{
		[DataMember]
		public string Province { get; set; }
		[DataMember]
		public string City { get; set; }
		[DataMember]
		public string DetailAddr { get; set; }
	}
}
