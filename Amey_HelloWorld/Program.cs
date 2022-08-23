using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amey_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Tyler Amey");
            }

            int f = 5;
            int g = 7;
            for(int i = 0; i < 5; i++)
            {
                f = g * f;
                Console.WriteLine(f);
            }

        }
    }
}
