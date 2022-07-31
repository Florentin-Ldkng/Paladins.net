using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class BountyItem
    {
        public string active { get; set; }
        public int bounty_item_id1 { get; set; }
        public int bounty_item_id2 { get; set; }
        public string bounty_item_name { get; set; }
        public int champion_id { get; set; }
        public string champion_name { get; set; }
        public string final_price { get; set; }
        public int initial_price { get; set; }
        public DateTime sale_end_datetime { get; set; }
        public string sale_type { get; set; }
    }
}
