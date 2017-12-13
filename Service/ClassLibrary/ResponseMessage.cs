using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class ResponseMessage
    {
        [MessageBodyMember]
        public string Name { get; set; }
        [MessageBodyMember]
        public int CheckResult { get; set; }
    }
}
