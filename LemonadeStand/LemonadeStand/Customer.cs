using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
         
        //member variables
 
        int temperaturePreference;
        int conditionPreference;
        double pricePreference;

        //constructor
        public Customer(Player player, Day today, Game game)
        {
            DecisionToBuy(player, today, game);
        }

        //member methods

        public void DecisionToBuy(Player player, Day today, Game game)
        {
            GetConditionPreference(game);
            GetTemperaturePreference(game);
            GetPricePreference(game);

            if(player.pricePerCup <= pricePreference && conditionPreference <= today.weather.actualConditionNumber && temperaturePreference <= today.weather.actualTemperature)
            {
                player.SellLemonade();  
            }

            else
            {    
            }
        }

        private void GetTemperaturePreference(Game game)
        {
            temperaturePreference = game.random.Next(55, 80);
        }

        private void GetConditionPreference(Game game)
        {
            conditionPreference = game.random.Next(1, 5);
        }

        private void GetPricePreference(Game game)
        {
            pricePreference = game.random.NextDouble();
        }
    }   
}
