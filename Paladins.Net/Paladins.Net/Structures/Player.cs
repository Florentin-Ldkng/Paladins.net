using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class Player
    {
        public int ActivePlayerId { get; set; }
        public int AvatarId { get; set; }
        public string AvatarURL { get; set; }
        public DateTime Created_Datetime { get; set; }
        public int HoursPlayed { get; set; }
        public int Id { get; set; }
        public DateTime Last_Login_Datetime { get; set; }
        public int Leaves { get; set; }
        public int Level { get; set; }
        public string LoadingFrame { get; set; }
        public int Losses { get; set; }
        public int MasteryLevel { get; set; }
        public MergedPlayer[] MergedPlayers { get; set; }
        public int MinutesPlayed { get; set; }
        public string Name { get; set; }
        public string Personal_Status_Message { get; set; }
        public string Platform { get; set; }
        public RankMode RankedConquest { get; set; }
        public RankMode RankedController { get; set; }
        public RankMode RankedKBM { get; set; }
        public string Region { get; set; }
        public int TeamId { get; set; }
        public string Team_Name { get; set; }
        public int Tier_Conquest { get; set; }
        public int Tier_RankedController { get; set; }
        public int Tier_RankedKBM { get; set; }
        public string Title { get; set; }
        public int Total_Achievements { get; set; }
        public int Total_Worshippers { get; set; }
        public int Total_XP { get; set; }
        public int Wins { get; set; }
        public string hz_gamer_tag { get; set; }
        public string hz_player_name { get; set; }
        public string ret_msg { get; set; }
    }
}
