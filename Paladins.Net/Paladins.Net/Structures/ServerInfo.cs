using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class ServerInfo
    {
        public DateTime entry_datetime { get; set; }
        public string environment { get; set; }
        public bool limited_access { get; set; }
        public string platform { get; set; }
        public string ret_msg { get; set; }
        public string status { get; set; }
        public string version { get; set; }
    }
}
