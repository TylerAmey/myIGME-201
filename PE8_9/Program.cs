using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            string line = Console.ReadLine();
            string newLine = "";
            int start = 0;
            foreach (string word in line.Split(' '))
            {
                string newWord = "";
                if (start == 0)
                {
                    newWord = "\u0022" + word + "\u0022";
                    newLine = newLine + newWord;
                    start = 1;
                }
                else
                {
                    newWord = "\u0022" + word + "\u0022";
                    newLine = newLine + " " + newWord;
                }
            }
            Console.WriteLine(newLine);
        }
    }
}
