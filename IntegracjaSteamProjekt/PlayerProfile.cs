using MySql.Data.MySqlClient;
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
    /// <summary>
    /// Klasa dla danych zawartych w profilu gracza
    /// </summary>
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

        /// <summary>
        /// Asynchroniczna funkcja do pobierania danych profilu gracza
        /// </summary>
        /// <param name="steamId">SteamId gracza</param>
        /// <returns>Obiekt klasy PlayerProfile z pobranymi danymi</returns>
        public static async Task<PlayerProfile> LoadDataAsync(ulong steamId)
        {
            var webInterfaceFactory = new SteamWebInterfaceFactory(Variables.ApiKey);
            var steamUserInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());
            var steamUserStatsInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUserStats>(new HttpClient());
            var steamPlatyerServiceInterface = webInterfaceFactory.CreateSteamWebInterface<PlayerService>(new HttpClient());
            var ownedGames = await steamPlatyerServiceInterface.GetOwnedGamesAsync(steamId);
            var friendsList = await steamUserInterface.GetFriendsListAsync(steamId);
            var playerSummary = await steamUserInterface.GetPlayerSummaryAsync(steamId);


            List<OwnedGame> ownedGamesList = new();
            foreach (var item in ownedGames.Data.OwnedGames)
            {
                var (name, description) = await GetAppDetailsAsync(item.AppId);
                if (!String.IsNullOrEmpty(name))
                {
                    ownedGamesList.Add(new OwnedGame
                    {
                        GameId = item.AppId,
                        Name = name,
                        PlayTime = (int)Math.Round(item.PlaytimeForever.TotalHours),
                        Description = description
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
                    GamesPrices.Rootobject appDetails = JsonSerializer.Deserialize<GamesPrices.Rootobject>(response);
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

        /// <summary>
        /// Asynchroniczna funkcja pobierająca nazwe gry i jej opis
        /// </summary>
        /// <param name="appId">Identyfikator gry</param>
        /// <returns>Tupla zawierająca nazwe gry i jej opis</returns>
        private static async Task<(string name, string description)> GetAppDetailsAsync(uint appId)
        {
            string name = "";
            string description = "";
            MySqlConnection connection = new(Variables.ConnectionString);
            await connection.OpenAsync();
            MySqlCommand command;
            string query = @"SELECT gn.game_name, gd.game_description FROM games_description AS gd LEFT JOIN game_names as gn on gn.game_id = gd.app_id
                                WHERE gd.app_id = @appId;";
            command = new(query, connection);
            command.CommandTimeout = 60;
            command.Parameters.AddWithValue("@appId", appId);

            using (MySqlDataReader dataReader = (MySqlDataReader)await command.ExecuteReaderAsync())
            {
                if (await dataReader.ReadAsync())
                {
                    name = dataReader.GetString(0);
                    description = dataReader.GetString(1);
                }
            }
            await connection.CloseAsync();
            return (name, description);

        }
    }
}
