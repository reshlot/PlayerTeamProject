using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTeam
{
    public  class Team
    {
        private List<Player> players;

        public Team()
        {
            players = new List<Player>();
        }

        public void AddPlayer(int playerId, string name, int age)
        {
            if (players.Count < 11)
            {
                Player player = new Player
                {
                    PlayerId = playerId,
                    Name = name,
                    Age = age
                };
                players.Add(player);
                Console.WriteLine(" ***Player added successfully.***");
            }
            else
            {
                Console.WriteLine("Cannot add more than 11 players to the team.!!!");
            }
        }

        public void RemovePlayer(int playerId)
        {
            Player player = players.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                players.Remove(player);
                Console.WriteLine("***Player removed successfully.***");
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }

        public void GetPlayerDetailsById(int playerId)
        {
            Player player = players.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                Console.WriteLine($"Player Id: {player.PlayerId}");
                Console.WriteLine($"Name: {player.Name}");
                Console.WriteLine($"Age: {player.Age}");
            }
            else
            {
                Console.WriteLine("Player not found.!!!!");
            }
        }

        public void GetPlayerDetailsByName(string name)
        {
            List<Player> matchingPlayers = players.FindAll(p => p.Name == name);
            if (matchingPlayers.Count > 0)
            {
                foreach (Player player in matchingPlayers)
                {
                    Console.WriteLine($"Player Id: {player.PlayerId}");
                    Console.WriteLine($"Name: {player.Name}");
                    Console.WriteLine($"Age: {player.Age}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Player not found.!!!");
            }
        }

        public void GetAllPlayerDetails()
        {
            if (players.Count > 0)
            {
                foreach (Player player in players)
                {
                    Console.WriteLine($"Player Id: {player.PlayerId}");
                    Console.WriteLine($"Name: {player.Name}");
                    Console.WriteLine($"Age: {player.Age}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No players in the team.!!!");
            }
        }
    }
}

