using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        //member variables

        //constructor

        //member methods

        public void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Steve's Lemonade Stand\nWould you like to play?\nPress '1' to continue.\nOtherwise, go away.\nNobody wants you around anyway.");

            if (Console.ReadLine() == "1")
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
