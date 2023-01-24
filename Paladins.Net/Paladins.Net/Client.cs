using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Paladins.Net.Structures;

namespace Paladins.Net
{
    public class Client
    {
        private RequestHandler _requestHandler = new RequestHandler();

        public Ping Ping()
        {
            Ping ping = new Ping();
            ping.Response = _requestHandler.Call<String>(Endpoints.PING);
            return ping;
        }
        public Session Login(string developerId, string authToken)
        {
            _requestHandler.ClientDefaultSetup();
            Credentials.devId = developerId;
            Credentials.oAuth = authToken;
            Session savingSession = _requestHandler.Call<Session>(EndpointFunctions.BuildUrl(Endpoints.CREATE_SESSION, "createsession"));
            Credentials.session = savingSession.session_id;
            return savingSession;
        }
        public TestSession TestSession()
        {
            TestSession test = new TestSession();
            test.Response = _requestHandler.Call<String>(EndpointFunctions.BuildUrl(Endpoints.TEST_SESSION, "testsession"));
            return test;
        }
        public SessionInfo[] GetSessionInfo()
        {
            return _requestHandler.Call<SessionInfo[]>(EndpointFunctions.BuildUrl(Endpoints.GET_DATA_USED,
                "getdataused"));
        }
        public ServerInfo[] GetServerStatus()
        {
            return _requestHandler.Call<ServerInfo[]>(EndpointFunctions.BuildUrl(Endpoints.GET_HIREZ_SERVER_STATUS,
                "gethirezserverstatus"));
        }
        public PatchInfo GetPatchInfo()
        {
            return _requestHandler.Call<PatchInfo>(EndpointFunctions.BuildUrl(Endpoints.GET_PATCH_INFO,
                "getpatchinfo"));
        }
        public Champion[] GetChampions(LanguageCode languageCode)
        {
            return _requestHandler.Call<Champion[]>(EndpointFunctions.BuildUrl(Endpoints.GET_CHAMPIONS, "getchampions",
                languageCode.ToString("D")));
        }
        public ChampionCard[] GetChampionCards(ChampionId championId, LanguageCode languageCode)
        {
            return _requestHandler.Call<ChampionCard[]>(EndpointFunctions.BuildUrl(Endpoints.GET_CHAMPION_CARDS, "getchampioncards",
                championId.ToString("D"), languageCode.ToString("D")));
        }
        public LeaderboardPlayer[] GetChampionLeaderboard(ChampionId championId)
        {
            return _requestHandler.Call<LeaderboardPlayer[]>(EndpointFunctions.BuildUrl(
                Endpoints.GET_CHAMPION_LEADERBOARD, "getchampionleaderboard", championId.ToString(), "428"));
        }
        public Player[] GetPlayer(string username)
        {
            return _requestHandler.Call<Player[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER, "getplayer",
                username));
        }
        public Player[] GetPlayersByIds(params int[] playerIds)
        {
            return _requestHandler.Call<Player[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER_BATCH,
                "getplayerbatch", string.Join(',', playerIds.Select(x => x.ToString()).ToArray())));
        }
        public PartialPlayer[] GetPlayerIdByName(string username)
        {
            return _requestHandler.Call<PartialPlayer[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER_ID_BY_NAME,
                "getplayeridbyname", username));
        }
        public ChampionSkins[] GetChampionSkins(ChampionId championId, LanguageCode languageCode)
        {
            return _requestHandler.Call<ChampionSkins[]>(EndpointFunctions.BuildUrl(Endpoints.GET_CHAMPION_SKINS,
                "getchampionskins", championId.ToString("D"), languageCode.ToString("D")));
        }
        public BountyItem[] GetBountyItems()
        {
            return _requestHandler.Call<BountyItem[]>(EndpointFunctions.BuildUrl(Endpoints.GET_BOUNTY_ITEMS,
                "getbountyitems"));
        }
        public ChampionRank[] GetChampionRanks(int playerId)
        {
            return _requestHandler.Call<ChampionRank[]>(EndpointFunctions.BuildUrl(Endpoints.GET_CHAMPION_RANKS,
                "getchampionranks", playerId.ToString("D")));
        }
        public PlayerStatusShort[] GetPlayerStatus(int playerId)
        {
            return _requestHandler.Call<PlayerStatusShort[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER_STATUS,
                "getplayerstatus", playerId.ToString("D")));
        }
        public MatchStat[] GetMatchHistory(int playerId)
        {
            return _requestHandler.Call<MatchStat[]>(EndpointFunctions.BuildUrl(Endpoints.GET_MATCH_HISTORY,
                "getmatchhistory", playerId.ToString("D")));
        }
        public Loadout[] GetPlayerLoadouts(int playerId,LanguageCode languageCode)
        {
            return _requestHandler.Call<Loadout[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER_LOADOUTS,
                "getplayerloadouts", playerId.ToString("D"),languageCode.ToString("D")));
        }

        public string TestReturn()
        {
            Console.WriteLine("in test");
            return _requestHandler.Call<string>(EndpointFunctions.BuildUrl(Endpoints.GET_HIREZ_SERVER_STATUS,
                "gethirezserverstatus"));
           
        }
    }
}
