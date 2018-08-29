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
        int temperature;
        string conditions;
        Random randomNumber = new Random();


        //constructor

        //member methods
        public void GetTodaysWeather()
        {
            SetTodaysTemperature();
            SetTodaysConditions();
            Console.WriteLine("Today's weather is " + temperature + " degrees and " + conditions);
        }


        public void SetTodaysTemperature()
        { 
            temperature = randomNumber.Next(55, 80);
            //Console.WriteLine("Todays weather is:\n" + temperature + " degrees");
        }

        public void SetTodaysConditions()
        {
            int number = randomNumber.Next(1, 4);

            switch(number)
            {
                case 1:
                    conditions = "Sunny";
                    //Console.WriteLine("Sunny");
                    break;

                case 2:
                    conditions = "Mostly Cloudy";
                    //Console.WriteLine("Mosty Cloudy");
                    break;

                case 3:
                    conditions = "Overcast";
                    //Console.WriteLine("Overcast");
                    break;

                case 4:
                    conditions = "Rainy";
                    //Console.WriteLine("Rainy");
                    break;
            }
            
        }
    }
}
