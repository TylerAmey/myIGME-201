using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT1_BugSquash
{
    internal class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            //compile-time error: missing semi-colon
            int nY;
            int nAnswer;
            //compile-time error: missing "" around everything within the WriteLine
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                //compile-time error: must make sNumber = the ReadLine()
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            //logical error: must be nY not nX
            //compile-time error: missing !
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);
            //compile-time error: missing $
            Console.WriteLine($"{nX}^{nY} = {nAnswer}");
        }

        //compile-time error: must have static in front of the method
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //logical error: something to the 0 power equals 1
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //runtime error: must be nExponent -1
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }
            //compile-time error: missing "return" in "return returnval" (doesn't return a value) 
            return returnVal;
        }

    }
}
