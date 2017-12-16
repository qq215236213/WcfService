using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	[DataContract]
	public class Student
	{
		[DataMember]
		public string StudentName { get; set; }
		[DataMember]
		public int StudentAge { get; set; }
	}
}
