using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        int day = 0;
        //constructor

        //member methods

        public void GamePlay()
        {
            WelcomeToGame();

            while(day > 7)
            {
                
                //display weather
                //purchase inventory
                //set recipe
                //run day
                //display daily results
                //display running totals
                day++;
            }
        }

        public void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Steve's Lemonade Stand\nWould you like to play?\nPress '1' to continue.\nOtherwise, go away.\nNobody wants you around anyway.");

            if(Console.ReadLine() == "1")
            {
                Console.WriteLine("Let the game begin");
            }

            else
            {
                //end program
            }
        }
    }
}
