using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool bTruth = false;
            while(bTruth != true)
            {
                Console.WriteLine("Enter 2 numbers SEPPERATED BY COMMAS");
                string sNumbers = Console.ReadLine();
                string[] sNumberList = sNumbers.Split(',');
                double var1 = Double.Parse(sNumberList[0]);
                double var2 = Double.Parse(sNumberList[1]);
                if (((var1 > 10) && (var2 < 10)) || ((var1 < 10) && (var2 > 10)))
                {
                    bTruth = true;
                    Console.WriteLine("Valid input!");
                }
                else
                {
                    Console.WriteLine("Only 1 number can be above 10");
                }
            }
            




        }
    }
}
