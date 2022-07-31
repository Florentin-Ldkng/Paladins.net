using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class ChampionSkins
    {
        public int champion_id { get; set; }
        public string champion_name { get; set; }
        public string rarity { get; set; }
        public int skin_id1 { get; set; }
        public int skin_id2 { get; set; }
        public string skin_name { get; set; }
        public string skin_name_english { get; set; }
    }
}
