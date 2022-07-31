using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class PlayerStatusShort
    {
        public int Match { get; set; }
        public int match_queue_id { get; set; }
        public string personal_status_message { get; set; }
        public int status { get; set; }
        public string status_string { get; set; }
    }
}
