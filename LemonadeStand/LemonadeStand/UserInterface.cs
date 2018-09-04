using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        //member variables

        //constructor

        //member methods

        public static void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Steve's Lemonade Stand\n\nWould you like to play?\nPress '1' to continue.\n\nOtherwise, go away.\nNobody wants you around anyway.");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("\nLet the game begin.\n");
            }

            else
            {
                Environment.Exit(0);
            }
        }

        public static void DisplayRules()
        {
            Console.WriteLine("You have 7 days to make as much money as possible. You have control of pricing, the recipe, inventory, and purchasing \nsupplies. Buy ingredients, set your recipe and start selling. You'll have to deal with the weather, which plays a part \nwhen customers are deciding to buy.\n\n");
        }

        public void EndOfGame(Player player)
        {
            Console.WriteLine("You have reached the end of the game.\n\nYou have sold:\n" + player.totalCupsSold + " cups of lemonade\nand you have made:\n$" + player.totalMoneyMade);
        }
    }
}
