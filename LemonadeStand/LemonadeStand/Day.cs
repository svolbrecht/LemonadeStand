using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables
        //List<Customer>
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }

        //member methods

        public void CreateCusomers(Player player, Game game)
        {
            for(int i = 0; i <= 100; i++)
            {
                customers.Add(new Customer(player, weather, game));
            }
        }
    }
}
