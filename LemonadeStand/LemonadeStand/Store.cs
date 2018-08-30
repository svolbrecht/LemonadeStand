using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables
        public double price;
        public int quantity;

        //constructor

        //member methods

        public void GetSupplies(Player player)
        {
            Console.WriteLine("Purchase options:\nFor cups, Press '1'\nFor lemons, Press '2'\nFor sugar, Press '3'\nFor ice cubes, Press '4'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    GetPaperCups();
                    CheckIfEnoughMoney(player);
                    player.inventory.paperCups += quantity;
                    break;

                case "2":
                    GetLemons();
                    CheckIfEnoughMoney(player);
                    player.inventory.lemons += quantity;
                    break;

                case "3":
                    GetCupsOfSugar();
                    CheckIfEnoughMoney(player);
                    player.inventory.cupsOfSugar += quantity;
                    break;

                case "4":
                    GetIceCubes();
                    CheckIfEnoughMoney(player);
                    player.inventory.iceCubes += quantity;
                    break;

                default:
                    Console.WriteLine("Please enter valid choice");
                    GetSupplies(player);
                    break;
            }

            Console.WriteLine("Purchase more supplies?\nFor yes - Press '1'\nFor no - Press any button");

            switch (Console.ReadLine())
            {
                case "1":
                    GetSupplies(player);
                    break;

                default:
                    break;
            }
        }

        public void GetPaperCups()
        {
            Console.WriteLine("Cup purchase options:\n25 cups for $.80 - Press '1'\n50 cups for $1.50 - Press '2'\n100 cups for $2.75 - Press '3'");
            string userInput = Console.ReadLine();
            //double price = 0;
            //int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = .8;
                    quantity = 25;
                    break;
                case "2":
                    price = 1.5;
                    quantity = 50;
                    break;
                case "3":
                    price = 2.75;
                    quantity = 100;
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    GetPaperCups();
                    break;
            }
        }

        public void GetLemons()
        {
            Console.WriteLine("Lemon purchase options\n10 Lemons for $.65 - Press '1'\n30 Lemons for $1.8 - Press '2'\n60 Lemons for $3.5 - Press '3'");
            string userInput = Console.ReadLine();
            //double price = 0;
            //int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = .65;
                    quantity = 10;
                    break;
                case "2":
                    price = 1.8;
                    quantity = 30;
                    break;
                case "3":
                    price = 3.5;
                    quantity = 60;
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    GetLemons();
                    break;
            }
        }

        //public void BuyLemons(Player player)
        //{
        //    Console.WriteLine("how many lemons");
        //    int boughtLemons = int.Parse(Console.ReadLine());

        //    for(int i = 0; i < boughtLemons; i++)
        //    {
        //        Lemon lemon = new Lemon();
        //        player.inventory.lemons.Add(lemon);                        //can make Selllemons separate methods

        //    }

        //    player.wallet.money -= (boughtLemons * player.inventory.lemons[0].price);
        //}


        public void GetCupsOfSugar()
        {
            Console.WriteLine("Sugar purchase options\n8 cups of sugar for $.70 - Press '1'\n20 cups of sugar for $1.30 - Press '2'\n45 cups of sugar for $2.50 - Press '3'");
            string userInput = Console.ReadLine();
            //double price = 0;
            //int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = .7;
                    quantity = 8;
                    break;
                case "2":
                    price = 1.3;
                    quantity = 20;
                    break;
                case "3":
                    price = 2.5;
                    quantity = 45;
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    GetCupsOfSugar();
                    break;
            }
        }

        public void GetIceCubes()
        {
            Console.WriteLine("Ice cube purchase options\n100 Ice cubes for $.85 - Press '1'\n250 Ice cubes for $2.00 - Press '2'\n500 Ice cubes for $3.90 - Press '3'");
            string userInput = Console.ReadLine();
            //double price = 0;
            //int quantity = 0;
            switch (userInput)
            {
                case "1":
                    price = .85;
                    quantity = 100;
                    break;
                case "2":
                    price = 2;
                    quantity = 250;
                    break;
                case "3":
                    price = 3.9;
                    quantity = 250;
                    break;
                default:
                    Console.WriteLine("Please enter valid choice");
                    GetIceCubes();
                    break;
            }
        }

        public void CheckIfEnoughMoney(Player player)
        {
            if(price > player.inventory.money)
            {
                Console.WriteLine("You do not have enough money");
            }

            else
            {
                player.inventory.money -= price;
            }
        }
    }
}
