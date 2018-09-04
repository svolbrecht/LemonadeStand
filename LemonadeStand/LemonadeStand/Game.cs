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
        Day today;
        public Random random;


        //constructor

        public Game()
        {
            player = new Player();
            store = new Store();
            today = new Day();
            random = new Random();

        }

        //member methods

        public void GamePlay(Game game)
        {
            UserInterface.WelcomeToGame();
            UserInterface.DisplayRules();

            while(day < 7)
            {

                //display weather
                today.weather.SetForecastedWeather(game);

                //purchase inventory
                store.AskGetSupplies(player);

                //set recipe
                player.recipe.QuestionChangeRecipe(player);
                player.ChangePricePerCup();

                //run day
                today.weather.SetActualWeather(game);
                today.CreateCusomers(player, today, game);

                //display daily results
                player.DisplayDailyResults();

                //display running totals
                player.DisplayWeeklyResults();


                day++;
            }


        }

       
    }
}
