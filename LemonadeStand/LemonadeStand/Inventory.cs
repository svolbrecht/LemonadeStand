using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        //member variables
        public int lemons;
        public int cupsOfSugar;
        public int paperCups;
        public int iceCubes;
        public double money = 20;


        //create parent class with lemons, sugar, ice cubes and cups as children
        //public List<Lemon> lemons = new List<Lemon>();



        //constructor




        //member methods

        public void DisplayInvetory()
        {
            Console.WriteLine("\n\nCurrent inventory:");
            Console.WriteLine(paperCups + " paper cups");
            Console.WriteLine(lemons + " lemons");
            Console.WriteLine(cupsOfSugar + " cups of sugar");
            Console.WriteLine(iceCubes + " ice cubes");
        }
        
    }
}
