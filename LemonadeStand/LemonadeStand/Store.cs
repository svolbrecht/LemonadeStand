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
    }
}
