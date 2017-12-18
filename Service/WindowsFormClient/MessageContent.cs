using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClient
{
    public class MessageContent
    {
        public string NickName { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsMe { get; set; }
    }
}
