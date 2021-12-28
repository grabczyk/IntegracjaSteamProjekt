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

namespace IntegracjaSteamProjekt
{
    public class PlayerProfile
    {
        private string playerName;
        private DateTime lastLogOff;
        private UserStatus playerStatus;
        private string url;
        /*
        private int numberOfAchivments;
        private int numberOfFriends;
        private int numberOfGames;
        */

        public string PlayerName { get => playerName; set => playerName = value; }
        public DateTime LastLogOff { get => lastLogOff; set => lastLogOff = value; }
        public UserStatus PlayerStatus { get => playerStatus; set => playerStatus = value; }
        public string Url { get => url; set => url = value; }

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
            var playerSummaryResponse = await steamInterface.GetPlayerSummaryAsync(steamId);
            var dupa = await steamUserStatsInterface.GetSchemaForGameAsync(945360);

            PlayerProfile profile = new PlayerProfile
            {
                playerName = playerSummaryResponse.Data.Nickname,
                lastLogOff = playerSummaryResponse.Data.LastLoggedOffDate,
                playerStatus = playerSummaryResponse.Data.UserStatus,
                Url = playerSummaryResponse.Data.AvatarMediumUrl

            };
            return profile;
        }
    }
}
