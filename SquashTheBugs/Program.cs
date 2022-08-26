using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //compile time error
            //logical error, should be double instead of int
            //int i = 0
            double i = 0;

            //runtime error, must cast string to a string
            //string allNumbers = null;
            string allNumbers = "";
            // loop through the numbers 1 through 10

            //logical error (would only go through 9
            //compile error, it should be "i++" not ++i
            //for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; i++)
            {
                // declare string to hold all numbers
                //logical error (the value has to be outside of the loop to be used in final string
                //string allNumbers = null;

                // output explanation of
                // compile time error, missing parenthasis around i-1
                //Console.Write(i + "/" + i - 1 + " = ");
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //runtime error (cannot divide by 0 (1 / 1-1)). This will skip 1 and not add it to the string
                //Console.WriteLine(i / (i - 1));
                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("Number cannot be processed.");
                }

                // concatenate each number to allNumbers
                //logical error (not adding the previous numbers to the string)
                //allNumbers += i + " ";
                allNumbers = allNumbers + " " + i;


                // increment the counter
                //i = i + 1;
                //logical error, no extra increment needed
            }

            // output all numbers which have been processed
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
