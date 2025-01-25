using IGDB;
using IGDB.Models;

var igdb = new IGDBClient(
  // Found in Twitch Developer portal for your app
  Environment.GetEnvironmentVariable("IGDB_CLIENT_ID"),
  Environment.GetEnvironmentVariable("IGDB_CLIENT_SECRET")
);
Console.WriteLine("Name of Game: ");
string? Gamename = Console.ReadLine() ?? "Error";
string queryString = $"fields id, name, total_rating, smilar_games; where name = \"{Gamename}\";";
// Simple fields
var games = await igdb.QueryAsync<Game>(IGDBClient.Endpoints.Games, query: queryString);
var game = games.First();
Console.WriteLine(game.Id); // 4
Console.WriteLine(game.Name); // Thief
Console.WriteLine(game.SimilarGames);
Console.WriteLine(game.TotalRating);

