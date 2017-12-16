using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class ResultMessage
    {
        [MessageHeader]
        public string ErrorMsg { get; set; }
        [MessageBodyMember]
        public bool IsSuccessed { get; set; }
    }
}
