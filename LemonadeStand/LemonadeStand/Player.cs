using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        //member variables
        public Inventory inventory;
        public Recipe recipe;
        public double pricePerCup = .20;
        public int paperCupsInPitcher;
        public int cupsSoldToday;
        public int totalCupsSold;
        public double moneyMadeToday;
        public double totalMoneyMade;
        public double moneySpent;
        public double profit;
        //constructor

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
        }

        //member methods
        
        public void ChangePricePerCup()
        {
            Console.WriteLine("\nCurrent price per cup:\n$" + pricePerCup);
            Console.WriteLine("\nSet price");
           
            try
            {
                pricePerCup = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Enter valid price. Must be a decimal or whole number.");
                ChangePricePerCup();
            }
        }

        public void MakePitcher()
        {
            if (inventory.paperCups >= 10 && inventory.lemons >= recipe.lemonsInRecipe && inventory.cupsOfSugar >= recipe.cupsOfSugarInRecipe && inventory.iceCubes >= recipe.iceCubesInRecipe)
            {
                inventory.lemons -= recipe.lemonsInRecipe;
                inventory.cupsOfSugar -= recipe.cupsOfSugarInRecipe;
                inventory.iceCubes -= (recipe.iceCubesInRecipe * 10);
                paperCupsInPitcher = 10;
                inventory.money += pricePerCup;
                paperCupsInPitcher -= 1;
                cupsSoldToday += 1;
                totalCupsSold += 1;
                moneyMadeToday += pricePerCup;
                totalMoneyMade += pricePerCup;
                Console.WriteLine("You sold a cup of lemonade");
            }
            else
            {
                Console.WriteLine("You have run out of supplies");
            }
        }

        public void SellLemonade()
        {
            if(paperCupsInPitcher > 0)
            {
                inventory.money += pricePerCup;
                paperCupsInPitcher -= 1;
                cupsSoldToday += 1;
                totalCupsSold += 1;
                moneyMadeToday += pricePerCup;
                totalMoneyMade += pricePerCup;
                Console.WriteLine("You sold a cup of lemonade");
            }
            else
            {
                MakePitcher();
            }
        }
        public void DisplayDailyResults()
        {
            Console.WriteLine("\nToday's results:\nYou sold " + cupsSoldToday + " cups of lemonade\nYou made $" + moneyMadeToday);
            cupsSoldToday = 0;
            moneyMadeToday = 0;
        }

        public void DisplayWeeklyResults()
        {
            Console.WriteLine("\nWeekly results:\nYou sold " + totalCupsSold + "\nYou made $" + totalMoneyMade);
        }

        public void SetProfit()
        {
            profit = totalMoneyMade - moneySpent;
        }

        public void EndOfGame()
        {
            Console.WriteLine("You have reached the end of the game.\n\nYour total cups of lemonade sold is:  " + totalCupsSold + "\nYour final profit is:\n$" + profit);

        }
    }
}
