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
        public Wallet wallet;

        //constructor

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        //member methods

    }
}
