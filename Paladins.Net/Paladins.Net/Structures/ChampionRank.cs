using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class ChampionRank
    {
        public int Assists { get; set; }
        public int Deaths { get; set; }
        public int Gold { get; set; }
        public int Kills { get; set; }
        public DateTime LastPlayed { get; set; }
        public int Losses { get; set; }
        public int MinionKills { get; set; }
        public int Minutes { get; set; }
        public int Rank { get; set; }
        public int Wins { get; set; }
        public int Worshippers { get; set; }
        public string champion { get; set; }
        public int champion_id { get; set; }
        public int player_id { get; set; }
    }
}
