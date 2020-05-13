using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            // Find all TEAMS with names starting with LA
            var teamsStartingWithLA = teams.Where(team => team.Name.StartsWith("LA")).ToList();
            // teamsStartingWithLA.ForEach(team => Console.WriteLine(team.Name));


            // Find all team NAMES which are playing in "Staples Center"
            var teamsPlayingInStaplesCenter = teams.Where(team => team.Arena.Equals("Staples Center"))
                                                      .Select(team => team.Name).ToList();
            // teamsPlayingInStaplesCenter.ForEach(team => Console.WriteLine(team));



            // Find all teams coaches
            var allCoaches = teams.Select(team => team.Coach).ToList();
            // allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));



            // Find 3 oldest coaches NAMES
            var oldest3CoahcesNames = allCoaches.OrderByDescending(coach => coach.Age)
                                                          .Take(3)
                                                            .Select(coach => coach.FullName)
                                                              .ToList();
            // oldest3CoahcesNames.ForEach(trainerName => Console.WriteLine(trainerName));



            // Group all teams by their arenas
            var groupedTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();
            //foreach (var group in groupedTeamsByArenas)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"-------------{team.Name}");
            //    }
            //}


            // Find all players in one LIST
             var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            //allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            //Find player with best avgPtsPerGame
            var playerWithMostPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                          .FirstOrDefault();
            //Console.WriteLine(playerWithMostPtsPerGame.FullName);


            // HOMEWORK

            // Find all coaches NAMES with Age > 50
            var oldCoaches = allCoaches.Where(coach => coach.Age > 50).Select(coach => coach.FullName).ToList();
            Console.WriteLine("All coaches NAMES with Age > 50:");
            oldCoaches.ForEach(coach => Console.WriteLine(coach));

            // Order players by AGE - DESC
            var playersByAGe = allPlayers.OrderByDescending(player => player.Age).Select(player => new {player.FullName, player.Age }).ToList();
            Console.WriteLine("\n\nOrder players by AGE - DESC");
            playersByAGe.ForEach(player => Console.WriteLine(player));


            // Find player with highest RebPerGame
            var HighestRPBPlayer = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"]).Take(1).ToList();
            Console.WriteLine("\n\nPlayer with highest RebPerGame:");
            HighestRPBPlayer.ForEach(player => Console.WriteLine(player.FullName));



            // Find all players with PtsPerGame > 20
            var playerWithPPG = allPlayers.Where(player => player.PlayerStatistic["PtsPerGame"] > 20).Select(player => player.FullName).ToList();
            Console.WriteLine("\n\nAll players with PtsPerGame > 20");
            playerWithPPG.ForEach(player => Console.WriteLine(player));


            // Find all players NAMES older then 30 years
            var olderPlayers = allPlayers.Where(player => player.Age > 30).Select(player => player.FullName).ToList();
            Console.WriteLine("\n\nAll players NAMES older then 30 years");
            olderPlayers.ForEach(player => Console.WriteLine(player));

            // Group players by age
            var groupedPlayersByAge = allPlayers.OrderBy(player => player.Age).GroupBy(player => player.Age).ToList();
            Console.WriteLine("\n\nGrouped players by age:");
            foreach (var group in groupedPlayersByAge)
            {
                Console.WriteLine($"{group.Key}");
                foreach (var player in group)
                {
                    Console.WriteLine($"-------------{player.FullName}");
                }
            }

            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0
            var playersWithALotOfRPG = allPlayers.Where(player => player.PlayerStatistic["RebPerGame"] > 7.0).OrderBy(player => player.PlayerStatistic["PtsPerGame"])
                .Select(player => new { player.FullName, player.PlayerStatistic }).ToList();

            Console.WriteLine("\n\nAll players NAMES and PtsPerGame if have RebPerGame > 7.0");
            playersWithALotOfRPG.ForEach(player => Console.WriteLine($"{player.FullName}, PtsPerGame: {player.PlayerStatistic["PtsPerGame"]}"));


            // Find first 3 players with highest PtsPerGame
            var highestPPGPlayers = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).Take(3).ToList();
            Console.WriteLine("\n\nFirst 3 players with highest PtsPerGame");
            highestPPGPlayers.ForEach(player => Console.WriteLine(player.FullName));

            // Find the team which has the player with highest PtsPerGame
            var highestPPGPlayer = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"]).FirstOrDefault();
            var teamWithHighestPlayer = teams.FirstOrDefault(team => team.Players.Contains(highestPPGPlayer));
            Console.WriteLine("\n\n" + teamWithHighestPlayer.Name);


            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC
            var finalPlayers = allPlayers.OrderByDescending(player => player.PlayerStatistic["RebPerGame"])
                .Take(4).OrderBy(player => player.PlayerStatistic["PtsPerGame"]).ToList();
            finalPlayers.ForEach(player => Console.WriteLine($"{ player.FullName} PtsPerGame: {player.PlayerStatistic["PtsPerGame"]}"));





            Console.ReadLine();

        }
    }
}
