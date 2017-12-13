using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [MessageContract]
    public class Worker
    {
        [MessageHeader]
        public ArtistInfo WorkerArtist { get; set; }
        [MessageBodyMember]
        public string WorkerName { get; set; }
        [MessageBodyMember]
        public string WorkerNo { get; set; }
        [MessageBodyMember]
        public int WorkerAge { get; set; }
    }
}
