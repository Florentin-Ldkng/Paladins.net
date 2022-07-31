using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;
using Paladins.Net.Structures;

namespace Paladins.Net
{
    public static class Endpoints
    {
        private const string Url = "https://api.paladins.com/paladinsapi.svc/";
        public static string PING = $"{Url}pingJson";
        public static string CREATE_SESSION = $"{Url}createsessionJson";
        public static string TEST_SESSION = $"{Url}testsessionJson";
        public static string GET_DATA_USED = $"{Url}getdatausedJson";
        public static string GET_HIREZ_SERVER_STATUS = $"{Url}gethirezserverstatusJson";
        public static string GET_PATCH_INFO = $"{Url}getpatchinfoJson";
        public static string GET_CHAMPIONS = $"{Url}getchampionsJson";
        public static string GET_CHAMPION_CARDS = $"{Url}getchampioncardsJson";
        public static string GET_CHAMPION_LEADERBOARD = $"{Url}getchampionleaderboardJson";
        public static string GET_CHAMPION_SKINS = $"{Url}getchampionskinsJson";
        public static string GET_CHAMPION_RANKS = $"{Url}getchampionranksJson";
        public static string GET_PLAYER = $"{Url}getplayerJson";
        public static string GET_PLAYER_BATCH = $"{Url}getplayerbatchJson";
        public static string GET_PLAYER_ID_BY_NAME = $"{Url}getplayeridbynameJson";
        public static string GET_BOUNTY_ITEMS = $"{Url}getbountyitemsJson";


    }
}
