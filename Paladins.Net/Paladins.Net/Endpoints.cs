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
        public static string GET_PLAYER = $"{Url}getplayerJson";
        public static string GET_PLAYER_BATCH = $"{Url}getplayerbatchJson";
        public static string GET_PLAYER_ID_BY_NAME = $"{Url}getplayeridbynameJson";

    }
}
