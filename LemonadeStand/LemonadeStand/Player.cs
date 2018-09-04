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
        //constructor

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
        }

        //member methods
        
        public void ChangePricePerCup()
        {
            Console.WriteLine(pricePerCup);
            Console.WriteLine("Set price");
            pricePerCup = double.Parse(Console.ReadLine());
        }

        public void MakePitcher()
        {
            if (inventory.paperCups >= 10 && inventory.lemons >= recipe.lemonsInRecipe && inventory.cupsOfSugar >= recipe.cupsOfSugarInRecipe && inventory.iceCubes >= recipe.iceCubesInRecipe)
            {
                inventory.lemons -= recipe.lemonsInRecipe;
                inventory.cupsOfSugar -= recipe.cupsOfSugarInRecipe;
                inventory.iceCubes -= recipe.iceCubesInRecipe;
                paperCupsInPitcher = 10;
            }
            else
            {

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
            }
            else if(paperCupsInPitcher == 0)
            {
                MakePitcher();
            }
            else
            {

            }
        }
        public void DisplayDailyResults()
        {
            Console.WriteLine("\nToday you sold " + cupsSoldToday + " cups of lemonade");
        }

        public void DisplayWeeklyResults()
        {
            Console.WriteLine("\nYou have sold " + totalCupsSold + " total");
        }
    }
}
