using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string read = Console.ReadLine();
            char[] chars = read.ToCharArray();
            char[] backwards = new char[chars.Length];
            int counter = 0;
            for (int i = (chars.Length - 1); i >= 0; i--)
            {
                backwards[i] = chars[counter];
                counter++;
            }
            string newString = new string(backwards);
            Console.WriteLine(newString);
        }
    }
}
