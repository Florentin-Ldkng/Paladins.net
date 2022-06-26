# Examples

### Ping:
**Usage:**
`client.Ping()`  
**Returns:** [Ping](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Ping.cs)  

### Create Session:
**Usage:**
`client.Login("DevId", "AuthToken")`  
**Returns:** [Session](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Session.cs)  

### Test Session:
**Usage:**
`client.TestSession()`  
**Returns:** [TestSession](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/TestSession.cs)

### Get Session Info:
**Usage:**
`client.GetSessionInfo()`  
**Returns:** [SessionInfo[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/SessionInfo.cs)

### Get Server Status:
**Usage:**
`client.GetServerStatus()`  
**Returns:** [ServerInfo[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/ServerInfo.cs)

### Get Patch Info:
**Usage:**
`client.GetPatchInfo()`  
**Returns:** [PatchInfo](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/PatchInfo.cs)

### Get Champions:
**Usage:**
`client.GetChampions(LanguageCode)`  
**Returns:** [Champion[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Champion.cs)  

### Get ChampionCards:
**Usage:**
`client.GetChampionCards(ChampionId, LanguageCode)`  
**Returns:** [ChampionCard[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/ChampionCard.cs)

### Get Champion Leaderboard:
**Usage:**
`client.GetChampionLeaderboard(ChampionId)`  
**Returns:** [LeaderboardPlayer[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/LeaderboardPlayer.cs)

### Get Player:
**Usage:**
`client.GetPlayer("PlayerName")`  
**Returns:** [Player[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Player.cs)

### Get Players by Ids:
**Usage:**
`client.GetPlayersByIds(PlayerId,PlayerId,PlayerId)` | `client.GetPlayersByIds(PlayerId[ ])`  
**Returns:** [Player[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Player.cs)

### Get PlayerId by Name:
**Usage:**
`client.GetPlayerIdByName("PlayerName")`  
**Returns:** [PartialPlayer[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/PartialPlayer.cs)
