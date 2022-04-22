using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        public static void Attack(Character attacker, Character defender)
        {
            Random diceRoll = new Random();
            int result = diceRoll.Next(1, 101);
            System.Threading.Thread.Sleep(35);//Results in different values for Player and Monster because random is based off of time

            if (result <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }//end Attack()

        public static void Battle(Player player, Monster monster)
        {
            Random speedRoll = new Random();
            int playerSpeed = speedRoll.Next(1, 11) + player.Speed;
            System.Threading.Thread.Sleep(25);
            int monsterSpeed = speedRoll.Next(1, 11) + monster.Speed;
            Console.WriteLine($"{(playerSpeed >= monsterSpeed ? $"{player.Name}" : $"{ monster.Name}")}  attacks first!");
            if (playerSpeed >= monsterSpeed)
            {
                Attack(player, monster);
                if (monster.Life > 0)
                {
                    Attack(monster, player);
                }//end 
            }//end if player attacks first
            else
            {
                Attack(monster, player);
                if (player.Life > 0)
                {
                    Attack(player, monster);
                }
            }//end else monster attacks first

        }
    }
}
