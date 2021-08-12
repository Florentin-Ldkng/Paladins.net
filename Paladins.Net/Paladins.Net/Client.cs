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
            Session savingSession = _requestHandler.Call<Session>(EndpointFunctions.BuildUrl(Endpoints.CREATE_SESSION,"createsession"));
            Credentials.session = savingSession.session_id;
            return savingSession;
        }
        public TestSession TestSession()
        {
            TestSession test = new TestSession();
            test.Response = _requestHandler.Call<String>(EndpointFunctions.BuildUrl(Endpoints.TEST_SESSION,"testsession"));
            return test;
        }
        public SessionInfo[] GetSessionInfo()
        {
            return _requestHandler.Call<SessionInfo[]>(EndpointFunctions.BuildUrl(Endpoints.GET_DATA_USED,
                "getdataused"));
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

        
    }
}
