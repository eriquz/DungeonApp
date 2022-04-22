using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string playerName = "";
            PlayerRace race = new PlayerRace();


            Console.Title = "Behold! The Cave of Caer Bannow!";

            Console.Write("Welcome, hero! Enter your name: ");
            playerName = Console.ReadLine();
            Console.Clear();


            bool validRace = false;
            do
            {
                Console.WriteLine("Choose your race:\n" +
                    "E)lf (increased life)\n" +
                    "M)age (decreased speed, increased block)\n" +
                    "H)uman (standard starting stats)\n" +
                    "O)gre (increased hitchance, decreased speed)\n");
                ConsoleKey raceChoice = Console.ReadKey().Key;
                Console.Clear();
                switch (raceChoice)
                {
                    case ConsoleKey.E:
                        race = PlayerRace.Elf;
                        validRace = true;
                        break;

                    case ConsoleKey.M:
                        race = PlayerRace.Mage;
                        validRace = true;
                        break;

                    case ConsoleKey.H:
                        race = PlayerRace.Human;
                        validRace = true;
                        break;

                    case ConsoleKey.O:
                        race = PlayerRace.Ogre;
                        validRace = true;
                        break;

                    default:
                        Console.WriteLine("That was not a valid choice.");
                        break;
                }
            } while (!validRace);

            Weapon jaggedDagger = new Weapon("Jagged Dagger", 1, 5, -3, false);


            Player player = new Player(playerName, 50, 50, 20, 25, 20, race, jaggedDagger);


            Console.WriteLine($"Welcome, {playerName} the {player.Race}. Your journey begins...");
            Console.WriteLine("The cave before you is dark and littered with bones.\n" +
                "You pass through it and you descend into a forgotten dungeon complex...");


            bool exit = false;

            do
            {
                Monster draugr = new Monster("Draugr", 15, 15, 10, 0, 15, 5, 15, "The ancient creature stands tall. His sparse remaining flesh hangs loosely, and it is unclear how long he has been in this state of unliving.");
                Monster xenomorph = new Monster("Xenomorph", 30, 30, 10, 5, 20, 10, 25, "It's gigantic, gleaming body rises far above any you've ever seen. As its mouth opens, you see something moving inside...");
                bool isDragonFlying = new Random().Next(1, 11) <= 5 ? true : false;
                Dragon dragon = new Dragon("Dragon", 30, 30, 65, 30, 15, 8, 18, "An ancient being looms before you, years of tormenting chaos behind its eyes piercing your soul.", isDragonFlying);


                Monster[] monsters =
                {
                    draugr, draugr, draugr, draugr, xenomorph, dragon
                };
                Monster monster = monsters[new Random().Next(monsters.Length)];

                Console.WriteLine(Room.GetRoom());
                Console.WriteLine($"A {monster.Name} stands before you!");


                bool reloadRoom = false;

                do
                {
                    Console.WriteLine("\nChoose an action:\n" +
                        "A)ttack\n" +
                        "F)lee\n" +
                        "P)layer Stats\n" +
                        "M)onster Stats\n" +
                        "Esc) to exit");
                    ConsoleKey userChoice = Console.ReadKey().Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Combat.Battle(player, monster);
                            if (monster.Life < 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"{monster.Name} drops dead to the ground!");
                                Console.ResetColor();
                                reloadRoom = true;
                                score++;
                            }
                            break;

                        case ConsoleKey.F:
                            Console.WriteLine($"You turn and flee from the room. As your back is turned, {monster.Name} strikes you.");
                            Combat.Attack(monster, player);
                            reloadRoom = true;
                            break;

                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            break;

                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("You have chosen to abandon your mission.");
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("You haven't chosen an option that is available to you.\n");
                            break;
                    }
                    if (player.Life < 1)
                    {
                        Console.WriteLine($"You have been slain by the {monster.Name}.\n");
                        exit = true;
                    }





                } while (reloadRoom != true && exit != true);








            } while (exit != true);
            Console.WriteLine($"You killed {score} monster{(score == 1 ? "" : "s")}.");
            Console.WriteLine("GAME OVER");

        }//end Main()
    }//end class
}//end namespace
