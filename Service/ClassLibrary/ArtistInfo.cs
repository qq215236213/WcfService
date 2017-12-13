using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [DataContract]
    public class ArtistInfo
    {
        [DataMember]
        public string ArtistName { get; set; }

        [DataMember]
        public DateTime CreateTime { get; set; }
    }
}
