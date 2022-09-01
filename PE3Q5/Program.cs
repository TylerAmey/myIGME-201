using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 INTEGER values.");
            string sIntegers = Console.ReadLine();
            string[] sSplitIntegers = sIntegers.Split(" ");
            int nProduct = 0;

            foreach (string s in sSplitIntegers)
            {
                int nInteger = Convert.ToInt32(s);
                nProduct = nProduct * nInteger;
            }

            Console.WriteLine(nProduct);


        }
    }
}
 