using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class LeaderboardPlayer
    {
        public int champion_id { get; set; }
        public int losses { get; set; }
        public int player_id { get; set; }
        public string player_name { get; set; }
        public float player_ranking { get; set; }
        public int rank { get; set; }
        public string ret_msg { get; set; }
        public int wins { get; set; }
    }
}
