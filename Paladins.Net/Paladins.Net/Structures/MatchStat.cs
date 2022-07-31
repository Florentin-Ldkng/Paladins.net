using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paladins.Net.Structures
{
    public class MatchStat
    {
        public int ActiveId1 { get; set; }
        public int ActiveId2 { get; set; }
        public int ActiveId3 { get; set; }
        public int ActiveId4 { get; set; }
        public int ActiveLevel1 { get; set; }
        public int ActiveLevel2 { get; set; }
        public int ActiveLevel3 { get; set; }
        public int ActiveLevel4 { get; set; }
        public string Active_1 { get; set; }
        public string Active_2 { get; set; }
        public string Active_3 { get; set; }
        public string Active_4 { get; set; }
        public int Assists { get; set; }
        public string Champion { get; set; }
        public int ChampionId { get; set; }
        public int Creeps { get; set; }
        public int Damage { get; set; }
        public int Damage_Bot { get; set; }
        public int Damage_Done_In_Hand { get; set; }
        public int Damage_Mitigated { get; set; }
        public int Damage_Structure { get; set; }
        public int Damage_Taken { get; set; }
        public int Damage_Taken_Magical { get; set; }
        public int Damage_Taken_Physical { get; set; }
        public int Deaths { get; set; }
        public int Distance_Traveled { get; set; }
        public int Gold { get; set; }
        public int Healing { get; set; }
        public int Healing_Bot { get; set; }
        public int Healing_Player_Self { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public int ItemId3 { get; set; }
        public int ItemId4 { get; set; }
        public int ItemId5 { get; set; }
        public int ItemId6 { get; set; }
        public int ItemLevel1 { get; set; }
        public int ItemLevel2 { get; set; }
        public int ItemLevel3 { get; set; }
        public int ItemLevel4 { get; set; }
        public int ItemLevel5 { get; set; }
        public int ItemLevel6 { get; set; }
        public string Item_1 { get; set; }
        public string Item_2 { get; set; }
        public string Item_3 { get; set; }
        public string Item_4 { get; set; }
        public string Item_5 { get; set; }
        public string Item_6 { get; set; }
        public int Killing_Spree { get; set; }
        public int Kills { get; set; }
        public int Level { get; set; }
        public string Map_Game { get; set; }
        public int Match { get; set; }
        public int Match_Queue_Id { get; set; }
        public DateTime Match_Time { get; set; }
        public int Minutes { get; set; }
        public int Multi_kill_Max { get; set; }
        public int Objective_Assists { get; set; }
        public string Queue { get; set; }
        public string Region { get; set; }
        public string Skin { get; set; }
        public int SkinId { get; set; }
        public int Surrendered { get; set; }
        public int TaskForce { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }
        public int Time_In_Match_Seconds { get; set; }
        public string Win_Status { get; set; }
        public int Winning_TaskForce { get; set; }
        public int playerId { get; set; }
        public string playerName { get; set; }
    }
}
