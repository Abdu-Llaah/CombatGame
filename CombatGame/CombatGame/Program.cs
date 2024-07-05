using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombatGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerMP = 10;
            int computerMp = 15;

            int playerAttack = 5;
            int computerAttack = 7;

            int healAmount = 30;

            Random random = new Random();

            while (playerMP > 0 && computerMp > 0)
            {
                //player turn
                Console.WriteLine("..Player turn...");
                Console.WriteLine("playerMp - " + playerMP + "computerMp" +computerMp);
                
                Console.WriteLine("enter a to Attack or h to Heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    computerMp -= playerAttack; //is the same as computerMp = computerMp - playermp
                    Console.WriteLine("Player Attack computer and deals" + playerAttack + "damage!");
                }
                else
                {
                    playerMP += healAmount;
                    Console.WriteLine("Player restores" + healAmount + "health points");

                }

                //computer turn
                if (computerMp > 0)
                {
                    Console.WriteLine("... computer turn ... ");
                    Console.WriteLine("playerMp - " + playerMP + "computerMp" + computerMp);
                    int computerChoice = random.Next(0, 2);


                    if (computerChoice == 0)
                    {
                        playerMP -= computerAttack;
                        Console.WriteLine("computer Attacks and deals"  + computerAttack + "Health point");
                    }

                }
            }

            if (playerMP > 0)
            {
                Console.WriteLine("congratulations, you have won! ");
            }
            else
            {
                Console.WriteLine("sorry you lose!");
            }

        }
        
    }
}
