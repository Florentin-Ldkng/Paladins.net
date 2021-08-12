using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class Champion
    {
        public Ability Ability_1 { get; set; }
        public Ability Ability_2 { get; set; }
        public Ability Ability_3 { get; set; }
        public Ability Ability_4 { get; set; }
        public Ability Ability_5 { get; set; }
        public string ChampionCard_URL { get; set; }
        public string ChampionIcon_URL { get; set; }
        public int Health { get; set; }
        public string Lore { get; set; }
        public string Name { get; set; }
        public string Name_English { get; set; }
        public string OnFreeWeeklyRotation { get; set; }
        public string Roles { get; set; }
        public int Speed { get; set; }
        public string Title { get; set; }
        public int id { get; set; }
        public string latestChampion { get; set; }

    }
}
