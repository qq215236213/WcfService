using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class RequestMessage
    {
        [MessageHeader]
        public int MaxNum { get; set; }
        [MessageBodyMember]
        public string CheckName { get; set; }
    }
}
