using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTeam
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Team team = new Team();

                while (true)
                {
                Console.WriteLine("***FasatPace Cricket Academy***\n");
                Console.WriteLine("1. Add player");
                    Console.WriteLine("2. Remove player");
                    Console.WriteLine("3. Get player details by Id");
                    Console.WriteLine("4. Get player details by name");
                    Console.WriteLine("5. Get all player details");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Enter your choice: ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter player Id: ");
                            int playerId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter player name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter player age: ");
                            int age = int.Parse(Console.ReadLine());
                            team.AddPlayer(playerId, name, age);
                            break;
                        case 2:
                            Console.WriteLine("Enter player Id to remove: ");
                            int playerIdToRemove = int.Parse(Console.ReadLine());
                            team.RemovePlayer(playerIdToRemove);
                            break;
                        case 3:
                            Console.WriteLine("Enter player Id to get details: ");
                            int playerIdToGet = int.Parse(Console.ReadLine());
                            team.GetPlayerDetailsById(playerIdToGet);
                            break;
                        case 4:
                            Console.WriteLine("Enter player name to get details: ");
                            string nameToGet = Console.ReadLine();
                            team.GetPlayerDetailsByName(nameToGet);
                            break;
                        case 5:
                            team.GetAllPlayerDetails();
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        
    }

}

