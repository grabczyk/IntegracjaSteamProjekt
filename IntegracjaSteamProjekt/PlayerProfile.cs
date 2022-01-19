using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IntegracjaSteamProjekt
{
    public class PlayerProfile
    {
        public ulong SteamId { get; set; }
        public string PlayerName { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public string PlayerStatus { get; set; }
        public string Url { get; set; }
        public List<OwnedGame> OwnedGames { get; set; }
        public int NumberOfFriends { get; set; }
        public int TotalHoursPlayed { get; set; }
        public int OwnedGamesInitialValue { get; set; }
        public int OwnedGamesFinalValue { get; set; }

          async public static Task<PlayerProfile> LoadData(ulong steamId)
        {
            var webInterfaceFactory = new SteamWebInterfaceFactory(Variables.ApiKey);
            var steamUserInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());
            var steamUserStatsInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUserStats>(new HttpClient());
            var steamPlatyerServiceInterface = webInterfaceFactory.CreateSteamWebInterface<PlayerService>(new HttpClient());
            var ownedGames = await steamPlatyerServiceInterface.GetOwnedGamesAsync(steamId);
            var friendsList = await steamUserInterface.GetFriendsListAsync(steamId);
            var playerSummary = await steamUserInterface.GetPlayerSummaryAsync(steamId);
            //var bbb = await steamPlatyerInterface.GetRecentlyPlayedGamesAsync(steamId);
            //var ccc = await steamPlatyerInterface .GetBadgesAsync(steamId);
            //var ddd = await steamUserStatsInterface.GetUserStatsForGameAsync(steamId, 945360);
            //var dupa = await steamUserStatsInterface.GetSchemaForGameAsync(945360);


            List<OwnedGame> ownedGamesList = new();
            foreach (var item in ownedGames.Data.OwnedGames)
            {
                var gameSchema = await steamUserStatsInterface.GetSchemaForGameAsync(item.AppId);
                if (!String.IsNullOrEmpty(gameSchema.Data.GameName))
                {
                    ownedGamesList.Add(new OwnedGame
                    {
                        GameId = item.AppId,
                        Name = gameSchema.Data.GameName,
                        PlayTime = (int)Math.Round(item.PlaytimeForever.TotalHours)
                    });
                }
                
            }
            int totalHoursPlayed = ownedGamesList.Select(x => x.PlayTime).Sum();

            WebClient client = new();
            int initialGamesvalue = 0;
            int finalGamesvalue = 0;

            foreach (OwnedGame item in ownedGamesList)
            {
                string response = await client.DownloadStringTaskAsync(new Uri($@"https://store.steampowered.com/api/appdetails?appids={item.GameId}&cc=pl&l=pl"));
                Regex rx = new("(?<=price_overview\":)(.*)(?=,\"packages\")");
                response = rx.Match(response).Value;
                if (!String.IsNullOrEmpty(response))
                {
                    Prices.Rootobject appDetails = JsonSerializer.Deserialize<Prices.Rootobject>(response);
                    initialGamesvalue += appDetails.initial;
                    finalGamesvalue += appDetails.final;
                }


            }
            return new(steamId,
                    playerSummary.Data.Nickname,
                    playerSummary.Data.AccountCreatedDate,
                    playerSummary.Data.UserStatus.ToString(),
                    playerSummary.Data.AvatarFullUrl,
                    ownedGamesList,
                    friendsList.Data.Count,
                    totalHoursPlayed,
                    initialGamesvalue,
                    finalGamesvalue);

        }
        private PlayerProfile(ulong steamId, string playerName, DateTime accountCreationDate, string playerStatus, string url, List<OwnedGame> ownedGames, int numberOfFriends, int totalHoursPlayed, int ownedGamesInitialValue, int ownedGamesFinalValue)
        {
            SteamId = steamId;
            PlayerName = playerName;
            AccountCreationDate = accountCreationDate;
            PlayerStatus = playerStatus;
            Url = url;
            OwnedGames = ownedGames;
            NumberOfFriends = numberOfFriends;
            TotalHoursPlayed = totalHoursPlayed;
            OwnedGamesInitialValue = ownedGamesInitialValue;
            OwnedGamesFinalValue = ownedGamesFinalValue;
        }

        public PlayerProfile()
        {
        }
    }
}
