using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteColorAndNumber1
{

    using CAlias = FavoriteColorAndNumber1.Color;

    namespace Color
    {
        static public class ColorClass
        {
            public static string sFavColor;
        }
    }

    namespace Number
    {
        static public class NumberClass
        {
            public static string nFavNumber;
        }
    }





    //Class: Program
    //Author: Tyler Amey
    //Purpose Console Read/Write and Exception-handling exercise
    //Restrictions: none
    static internal class Program
    {

        static void 
        //Method: Main
        //Purpose: Prompt user for their favorite color and number
        //         Output their favorite color (in limit text colors) their favorite number
        //Restrictions: none
        static void Main(string[] args)
        {
            string sFavColor = null;
            sFavColor = "";
            sFavColor = sFavColor.ToUpper();

            int? nFavNumber = null;

            //prompt user for their favorite
            System.Console.Write("Enter your favorite color:\t");

            //get user's inoput and store it in a variable

            sFavColor = System.Console.ReadLine();

            CAlias.ColorClass.sFavColor = System.Console.ReadLine();

            //prompt the user for their favorite number
            System.Console.Write("Enter your favorite number:\t");

            do
            {
                try
                {
                    //get user's inoput and store it in a variable
                    nFavNumber = Convert.ToInt32(System.Console.ReadLine());
                    Number.NumberClass.nFavNumber = Convert.ToInt32(System.Console.ReadLine());
                }
                catch
                {
                    //validate that the user entered a valid number
                    Console.WriteLine("Please enter an integer");
                }
            } while (nFavNumber == null);

            while(nFavNumber == null)
            {
                try
                {
                    //get user's inoput and store it in a variable
                    nFavNumber = Convert.ToInt32(System.Console.ReadLine());
                }
                catch
                {
                    //validate that the user entered a valid number
                    Console.WriteLine("Please enter an integer");
                }
            }

            //change the color of the output text to match the user's favorite color
            switch (sFavColor.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
            }

            //output their favorite color the number of times as their favorite number
            for(int i = 0; i < nFavNumber; i+=1)
            {
                Console.WriteLine("Your favorite color is " + sFavColor + "!");
                //Same as above
                Console.WriteLine($"Your favorite color is {sFavColor}!");
                //Same as above
                Console.WriteLine("Your favorite color is {0}{1}", sFavColor, "!");
            }
        }
    }
}
