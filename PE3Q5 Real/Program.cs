using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3Q5_Real
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 4 INTEGER values SEPPERATED BY A COMMA (ex 1,2,3,4).");
            string sIntegers = Console.ReadLine();
            string[] sSplitIntegers = sIntegers.Split(',');
            int nProduct = 1;

            foreach (string s in sSplitIntegers)
            {
                int nInteger = Convert.ToInt32(s);
                nProduct = nProduct * nInteger;
            }

            Console.WriteLine(nProduct);
        }
    }
}
