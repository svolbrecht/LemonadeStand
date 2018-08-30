using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //member variables

        int day = 0;
        Player player;
        Store store;
        //Day day;
        //constructor

        public Game()
        {
            player = new Player();
            store = new Store();
        }

        //member methods
        UserInterface welcome = new UserInterface();
        Weather todaysWeather = new Weather();

        public void GamePlay()
        {
            welcome.WelcomeToGame();

            while(day <= 7)
            {

                //display weather
                todaysWeather.SetForecastedWeather();

                //purchase inventory
                store.GetSupplies(player);

                //set recipe

                //run day
                todaysWeather.SetActualWeather();
                //display daily results
                //display running totals
                day++;
            }
        }

       
    }
}
