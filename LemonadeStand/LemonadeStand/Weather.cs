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
        string actualConditions;
        int forecastedtemp;
        string forecastedcond;
        Random randomNumber = new Random();


        //constructor

        public Weather()
        {
            //setalltheweatherstuff();
        }

        //member methods

        //    public void setalltheweatherstuff()
        //{
        //    setactualweather()
        //    setactualcondition()
        //    setforecastedweather()
        //    setforecastedcondition()
        //}
        public void GetTodaysWeather()
        {
            SetTodaysTemperature();
            SetTodaysConditions();
            Console.WriteLine("Today's weather is " + actualTemperature + " degrees and " + actualConditions);
        }


        public void SetTodaysTemperature()
        { 
            actualTemperature = randomNumber.Next(55, 80);
            //Console.WriteLine("Todays weather is:\n" + temperature + " degrees");
        }

        public void SetTodaysConditions()
        {
            int number = randomNumber.Next(1, 4);

            switch(number)
            {
                case 1:
                    actualConditions = "Sunny";
                    //Console.WriteLine("Sunny");
                    break;

                case 2:
                    actualConditions = "Mostly Cloudy";
                    //Console.WriteLine("Mosty Cloudy");
                    break;

                case 3:
                    actualConditions = "Overcast";
                    //Console.WriteLine("Overcast");
                    break;

                case 4:
                    actualConditions = "Rainy";
                    //Console.WriteLine("Rainy");
                    break;
            }
            
        }
    }
}
