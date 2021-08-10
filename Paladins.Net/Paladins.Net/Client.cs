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
            Credentials.devId = developerId;
            Credentials.oAuth = authToken;
            Session savingSession = _requestHandler.Call<Session>(EndpointFunctions.BuildUrl(Endpoints.CREATE_SESSION,"createsession"));
            Credentials.session = savingSession.session_id;
            return savingSession;
        }
        public Player[] GetPlayer(string Username)
        {
            return _requestHandler.Call<Player[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER, "getplayer",
                Username));
        }
        public Player[] GetPlayersById(params int[] playerIds)
        {
            return _requestHandler.Call<Player[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER_BATCH,
                "getplayerbatch", playerIds.Select(x => x.ToString()).ToArray()));
        }
        public PartialPlayer[] GetPlayerIdByName(string Username)
        {
            return _requestHandler.Call<PartialPlayer[]>(EndpointFunctions.BuildUrl(Endpoints.GET_PLAYER_ID_BY_NAME,
                "getplayeridbyname", Username));
        }

        
    }
}
