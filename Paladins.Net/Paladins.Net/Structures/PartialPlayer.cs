using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class PartialPlayer
    {
        public string Name { get; set; }
        public int player_id { get; set; }
        public string portal { get; set; }
        public int portal_id { get; set; }
        public string privacy_flag { get; set; }
        public string ret_msg { get; set; }
    }
}
