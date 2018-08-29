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

        //constructor

        //member methods

        public void GetSupplies()
        {
            Console.WriteLine("Purchase options:\n For cups, enter '1'\nFor lemons, enter '2'\nFor sugar, enter '3'\nFor ice cubes, enter '4'");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    GetCups();
                    break;

                case "2":
                    GetLemons();
                    break;

                case "3":
                    GetCupsOfSugar();
                    break;

                case "4":
                    GetIceCubes();
                    break;

                default:
                    Console.WriteLine("Please enter valid choice.");
                    GetSupplies();
                    break;
            }
        }

        public void GetCups()
        {
            Console.WriteLine("Cup purchase options:\n25 cups for $.80 - Press '1'\n50 cups for $1.50 - Press '2'\n100 cups for $2.75 - Press '3'");
            string userInput = Console.ReadLine();
            double price = 0;
            int quantity = 0;
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
                    GetCups();
                    break;
            }
        }

        public void GetLemons()
        {
            Console.WriteLine("Lemon purchase options\n10 Lemons for $.65 - Press '1'\n30 Lemons for $1.8\n60 Lemons for $3.5 - Press '3'");
            string userInput = Console.ReadLine();
            double price = 0;
            int quantity = 0;
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

        public void GetCupsOfSugar()
        {

        }

        public void GetIceCubes()
        {

        }
    }
}
