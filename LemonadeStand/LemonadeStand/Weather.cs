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
        int actualTemperature;
        string actualCondition;
        int forecastedTemperature;
        string forecastedCondition;
        int weatherConditionNumber;
        Random randomNumber = new Random();


        //constructor

        public Weather()
        {
            SetAllWeather();
        }

        //member methods

        public void SetAllWeather()
        {
            SetForecastedWeather();
            SetActualWeather();
        }

        public void SetForecastedWeather()
        {
            SetForecastedTemperature();
            SetForecastedConditions();
            Console.WriteLine("Today's weather is forecasted to be:\n" + forecastedTemperature + " degrees and " + forecastedCondition);
        }


        public void SetForecastedTemperature()
        { 
            forecastedTemperature = randomNumber.Next(55, 80);
        }

        public void SetForecastedConditions()
        {
            weatherConditionNumber = randomNumber.Next(1, 5);

            switch(weatherConditionNumber)
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
        public void SetActualWeather()
        {
            SetActualTemperature();
            SetActualCondition();
            Console.WriteLine("Today's weather is:\n" + actualTemperature + " degrees and " + actualCondition);
        }

        public void SetActualTemperature()
        {
            actualTemperature = randomNumber.Next(forecastedTemperature - 4, forecastedTemperature + 5);
        }

        public void SetActualCondition()
        {
            if (weatherConditionNumber >= 2 && weatherConditionNumber <= 3)
            {
                switch (randomNumber.Next(weatherConditionNumber - 1, weatherConditionNumber + 2))
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

            else if(weatherConditionNumber == 1)
                switch (randomNumber.Next(weatherConditionNumber, weatherConditionNumber + 2))
                { 
                    case 1:
                    actualCondition = "Sunny";
                    break;
                case 2:
                    actualCondition = "Partly Cloudy";
                    break;
                }

            else if (weatherConditionNumber == 4)
                switch (randomNumber.Next(weatherConditionNumber - 1, weatherConditionNumber + 1))
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
