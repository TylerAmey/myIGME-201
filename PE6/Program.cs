using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomNumber = random.Next(0,101);

            Console.WriteLine(randomNumber.ToString());

            int tries = 1;
            bool bTruth = false;

            while (tries != 9)
            {
                Console.WriteLine("Guess a value between 0 and 100!");
                string sVal = Console.ReadLine();
                int nVal = int.Parse(sVal);
                if (nVal < 0 || nVal > 100)
                {
                    Console.WriteLine(nVal + " is an invalid number. Please enter a number between 0 and 100!");
                }
                else
                {
                    if(nVal == randomNumber)
                    {
                        Console.WriteLine("You got it! The value was " + randomNumber + ". It took you " + (tries) + " attempts!");
                        tries = 9;
                        bTruth = true;
                    }
                    else if(nVal < randomNumber)
                    {
                        Console.WriteLine("Too low!");
                        tries++;
                    }
                    else if (nVal > randomNumber)
                    {
                        Console.WriteLine("Too high!");
                        tries++;
                    }
                }
            }
            if(bTruth == false)
            {
                Console.WriteLine("You ran out of attempts! The number was " + randomNumber);
            }
        }
    }
}
