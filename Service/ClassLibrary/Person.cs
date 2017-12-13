using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class Person
    {
        [MessageHeader]
        public string Zip { get; set; }
        [MessageHeader]
        public string Address { get; set; }

        [MessageBodyMember]
        public int Age { get; set; }
        [MessageBodyMember]
        public string Name { get; set; }
        [MessageBodyMember]
        public string Email { get; set; }
    }
}
