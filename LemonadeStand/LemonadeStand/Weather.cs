using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables
        public int actualTemperature;
        string actualCondition;
        int forecastedTemperature;
        string forecastedCondition;
        int forecastedConditionNumber;
        public int actualConditionNumber;
        


        //constructor

        public Weather()
        {
            //SetAllWeather();
        }

        //member methods

        //public void SetAllWeather()
        //{
        //    SetForecastedWeather();
        //    SetActualWeather();
        //}

        public void SetForecastedWeather(Game game)
        {
            SetForecastedTemperature(game);
            SetForecastedConditions(game);
            Console.WriteLine("Today's weather is forecasted to be:\n" + forecastedTemperature + " degrees and " + forecastedCondition);
        }


        public void SetForecastedTemperature(Game game)
        { 
            forecastedTemperature = game.random.Next(55, 80);
        }

        public void SetForecastedConditions(Game game)
        {
            forecastedConditionNumber = game.random.Next(1, 5);

            switch(forecastedConditionNumber)
            {
                case 1:
                    forecastedCondition = "Sunny";
                    break;

                case 2:
                    forecastedCondition = "Partly Cloudy";
                    break;

                case 3:
                    forecastedCondition = "Overcast";
                    break;

                case 4:
                    forecastedCondition = "Rainy";
                    break;
            }
            
        }
        public void SetActualWeather(Game game)
        {
            SetActualTemperature(game);
            SetActualCondition(game);
            Console.WriteLine("Today's weather is:\n" + actualTemperature + " degrees and " + actualCondition);
        }

        public void SetActualTemperature(Game game)
        {
            actualTemperature = game.random.Next(forecastedTemperature - 4, forecastedTemperature + 5);
        }

        public void SetActualCondition(Game game)
        {
            if (forecastedConditionNumber >= 2 && forecastedConditionNumber <= 3)
            {
                actualConditionNumber = game.random.Next(forecastedConditionNumber - 1, forecastedConditionNumber + 2);

                switch (actualConditionNumber)
                {
                    case 1:
                        actualCondition = "Sunny";
                        break;

                    case 2:
                        actualCondition = "Partly Cloudy";
                        break;

                    case 3:
                        actualCondition = "Overcast";
                        break;

                    case 4:
                        actualCondition = "Rainy";
                        break;
                }
            }
            else if (forecastedConditionNumber == 1)
            {
                actualConditionNumber = game.random.Next(forecastedConditionNumber, forecastedConditionNumber + 2);

                switch (actualConditionNumber)
                {
                    case 1:
                        actualCondition = "Sunny";
                        break;
                    case 2:
                        actualCondition = "Partly Cloudy";
                        break;
                }
            }


            else if (forecastedConditionNumber == 4)
            {
                actualConditionNumber = game.random.Next(forecastedConditionNumber, forecastedConditionNumber + 2);

                switch (actualConditionNumber)
                {
                    case 3:
                        actualCondition = "Overcast";
                        break;
                    case 4:
                        actualCondition = "Rainy";
                        break;
                }
            }
        }
    }
}
