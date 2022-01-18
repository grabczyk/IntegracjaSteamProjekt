using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamWebAPI2.Utilities;
using System.Configuration;
using System.Net.Http;
using SteamWebAPI2.Interfaces;
using Steam.Models.SteamCommunity;
using System.Drawing;
using System.Text.Json;

namespace IntegracjaSteamProjekt
{
    public class PlayerProfile
    {
        private ulong steamId;
        private string playerName;
        private DateTime accountCreateDate;
        private string playerStatus;
        private string url;
        private List<OwnedGame>? ownedGames;
        private int numberOfFriends;
        private int? totalHoursPlayed;
        /*
        private int numberOfAchivments;
        private int numberOfFriends;
        private int numberOfGames;
        */

        public ulong SteamId { get => steamId; set => steamId = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public DateTime AccountCreationDate { get => accountCreateDate; set => accountCreateDate = value; }
        public string PlayerStatus { get => playerStatus; set => playerStatus = value; }
        public string Url { get => url; set => url = value; }
        public List<OwnedGame> OwnedGames { get => ownedGames; set => ownedGames = value; }
        public int NumberOfFriends { get => numberOfFriends; set => numberOfFriends = value; }

        public int TotalHoursPlayed
        {
            get
            {
                if (ownedGames != null)
                {
                    totalHoursPlayed = ownedGames.Select(x => x.PlayTime).Sum();
                }
                else
                {
                    totalHoursPlayed = 0;
                }
                return (int)totalHoursPlayed;
                } set => totalHoursPlayed = value; }
        


        /*
public int NumberOfAchivments { get => numberOfAchivments; set => numberOfAchivments = value; }
public int NumberOfFriends { get => numberOfFriends; set => numberOfFriends = value; }
public int NumberOfGames { get => numberOfGames; set => numberOfGames = value; }
*/

        public async Task<PlayerProfile> DownloadData(ulong steamId)
        {
            var webInterfaceFactory = new SteamWebInterfaceFactory("EBBFE1A1AA5EA1A9FCEE0158DC859F77");
            var steamInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());
            var steamUserStatsInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUserStats>(new HttpClient());
            var steamPlatyerInterface = webInterfaceFactory.CreateSteamWebInterface<PlayerService>(new HttpClient());
            var aaa = await steamPlatyerInterface.GetOwnedGamesAsync(steamId);
            var bbb = await steamPlatyerInterface.GetRecentlyPlayedGamesAsync(steamId);
            var ccc = await steamPlatyerInterface .GetBadgesAsync(steamId);
            var ddd = await steamUserStatsInterface.GetUserStatsForGameAsync(steamId, 945360);
            var eee = await steamInterface.GetFriendsListAsync(steamId);
            var playerSummaryResponse = await steamInterface.GetPlayerSummaryAsync(steamId);
            var dupa = await steamUserStatsInterface.GetSchemaForGameAsync(945360);

            PlayerProfile profile = new PlayerProfile
            {
                steamId = steamId,
                playerName = playerSummaryResponse.Data.Nickname,
                accountCreateDate = playerSummaryResponse.Data.AccountCreatedDate,
                playerStatus = playerSummaryResponse.Data.UserStatus.ToString(),
                url = playerSummaryResponse.Data.AvatarFullUrl,
                //ownedGames = (List<OwnedGameModel>)aaa.Data.OwnedGames,
                numberOfFriends = eee.Data.Count

            };

            List<OwnedGame> gamesList = new();
            foreach (var item in aaa.Data.OwnedGames)
            {
                var tmp = await steamUserStatsInterface.GetSchemaForGameAsync(item.AppId);
                if (!String.IsNullOrEmpty(tmp.Data.GameName))
                {
                    gamesList.Add(new OwnedGame
                    {
                        GameId = item.AppId,
                        Name = tmp.Data.GameName,
                        PlayTime = (int)Math.Round(item.PlaytimeForever.TotalHours)
                    });
                }
                
            }
            profile.ownedGames = gamesList;
            return profile;
        }
    }
}
