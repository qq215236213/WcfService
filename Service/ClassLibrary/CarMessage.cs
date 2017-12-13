using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class CarMessage
    {
        [MessageBodyMember]
        public string CarName { get; set; }
        [MessageBodyMember]
        public int MakeYear { get; set; }
        [MessageBodyMember]
        public string SerType { get; set; }
    }
}
