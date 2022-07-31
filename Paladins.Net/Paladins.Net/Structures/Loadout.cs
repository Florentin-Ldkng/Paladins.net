using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class Loadout
    {
        public int ChampionId { get; set; }
        public string ChampionName { get; set; }
        public int DeckId { get; set; }
        public string DeckName { get; set; }
        public LoadoutItem[] LoadoutItems { get; set; }
        public int playerId { get; set; }
        public string playerName { get; set; }
    }
}
