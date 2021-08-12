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

### Get Player:
**Usage:**
`client.GetPlayer("PlayerName")`  
**Returns:** [Player[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Player.cs)

### Get Players by Id:
**Usage:**
`client.GetPlayersById(PlayerId,PlayerId,PlayerId)` | `client.GetPlayersById(PlayerId[ ])`  
**Returns:** [Player[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/Player.cs)

### Get PlayerId by Name:
**Usage:**
`client.GetPlayerIdByName("PlayerName")`  
**Returns:** [PartialPlayer[ ]](https://github.com/de-MMXIV/Paladins.net/blob/master/Paladins.Net/Paladins.Net/Structures/PartialPlayer.cs)
