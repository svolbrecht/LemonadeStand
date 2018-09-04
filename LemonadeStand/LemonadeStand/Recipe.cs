using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        //member variables

        public int lemonsInRecipe = 4;
        public int cupsOfSugarInRecipe = 4;
        public int iceCubesInRecipe = 4;


        //constructor

        public Recipe()
        {

        }

        //member methods

        public void QuestionChangeRecipe(Player player)
        {
            DisplayCurrentRecipe();
            Console.WriteLine("\nSet recipe?\nFor yes - Press '1'\nFor no - Press any button");

            switch (Console.ReadLine())
            {
                case "1":
                    ChangeRecipe(player);
                    break;
                default:
                    break;
            }
        }

        public void ChangeRecipe(Player player)
        {
            ChangeNumberOfLemons();
            ChangeCupsOfSugar();
            ChangeIceCubes();
        }

        public void DisplayCurrentRecipe()
        {
            Console.WriteLine("\nCurrent recipe:");
            Console.WriteLine("Lemons: " + lemonsInRecipe);
            Console.WriteLine("Cups of Sugar: " + cupsOfSugarInRecipe);
            Console.WriteLine("Ice cubes: " + iceCubesInRecipe);
        }
        public void ChangeNumberOfLemons()
        {
            Console.WriteLine("Change lemons to: '3' '4' '5'\nDo not change - '0'");
            switch (Console.ReadLine())
            {
                case "3":
                    lemonsInRecipe = 3;
                    break;
                case "4":
                    lemonsInRecipe = 4;
                    break;
                case "5":
                    lemonsInRecipe = 5;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Enter valid response");
                    ChangeNumberOfLemons();
                    break;
            }
        }

        public void ChangeCupsOfSugar()
        {
            Console.WriteLine("Change cups of Sugar to: '3' '4' '5'\nDo not change - '0'");
            switch (Console.ReadLine())
            {
                case "3":
                    cupsOfSugarInRecipe = 3;
                    break;
                case "4":
                    cupsOfSugarInRecipe = 4;
                    break;
                case "5":
                    cupsOfSugarInRecipe = 5;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Enter valid response");
                    ChangeCupsOfSugar();
                    break;
            }
        }

        public void ChangeIceCubes()
        {
            Console.WriteLine("Change ice cubes to: '3' '4' '5'\nDo not change - '0'");
            switch (Console.ReadLine())
            {
                case "3":
                    iceCubesInRecipe = 3;
                    break;
                case "4":
                    iceCubesInRecipe = 4;
                    break;
                case "5":
                    iceCubesInRecipe = 5;
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Enter valid response");
                    ChangeIceCubes();
                    break;
            }
        }
    }
}
