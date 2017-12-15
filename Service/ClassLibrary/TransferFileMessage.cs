using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class TransferFileMessage
    {
        [MessageHeader]
        public string File_Name { get; set; }
        [MessageBodyMember]
        public Stream File_Stream { get; set; }
    }
}
