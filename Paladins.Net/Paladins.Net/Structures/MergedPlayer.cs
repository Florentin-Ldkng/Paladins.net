using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class MergedPlayer
    {
        public DateTime merge_datetime { get; set; }
        public int playerId { get; set; }
        public int portalId { get; set; }
    }
}
