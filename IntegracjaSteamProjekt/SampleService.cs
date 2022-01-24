using IntegracjaSteamProjekt;
using System;
using System.Xml.Linq;
using System.Threading;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

public class SampleService : ISampleService
{
    public async Task<List<string>> PlayerOwnedGames(string playerName)
    {
        MySqlConnection connection = new(Variables.ConnectionString);
        await connection.OpenAsync();
        MySqlCommand command;
        string query = @"SELECT DISTINCT `game_name` FROM `owned_games` WHERE raport_id = (SELECT `id` FROM `player_profile` WHERE player_name = @playerName ORDER BY 1 DESC LIMIT 1)";
        command = new(query, connection);
        command.CommandTimeout = 60;
        command.Parameters.AddWithValue("@playerName", playerName);

        MySqlDataReader dataReader = (MySqlDataReader)await command.ExecuteReaderAsync();
        List<string> games = new();
        while (await dataReader.ReadAsync())
        {
            games.Add(dataReader.GetString(0));
        }
        await connection.CloseAsync();
        return games;
    }

    public   string ProjectDescription()
    {
        return "Projekt na przedmiot Integracja Systemów Informatycznych z użyciem API Steam\n" +
            "Autorzy:\n" +
            "Grabowiec Michał\n" +
            "Wijaszka Marcin\n" +
            "Wiktor Sebastian";
    }
}