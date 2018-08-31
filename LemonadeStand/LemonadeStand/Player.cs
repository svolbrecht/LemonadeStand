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
        public int paperCupsInPitcher = 10;
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

        }

        public void SellLemonade()
        {
            if(paperCupsInPitcher >= 0 && inventory.paperCups != 0)
        }
    }
}
