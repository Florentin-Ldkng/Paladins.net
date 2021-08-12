using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class Ability
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public string Summary { get; set; }
        public string URL { get; set; }
        public string damageType { get; set; }
        public int rechargeSeconds { get; set; }
    }
}
