using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence with some yes' or no's");
            string line = Console.ReadLine();
            string newLine = "";
            int start = 0;
            foreach(string word in line.Split(' ')){
                string newWord = "";
                if(word == "yes")
                {
                    newWord = "no"; 
                }
                else if (word == "Yes")
                {
                    newWord = "No";
                }
                else if (word == "no")
                {
                    newWord = "yes";
                }
                else if (word == "No")
                {
                    newWord = "Yes";
                }
                else
                {
                    newWord = word;
                }
                if(start == 0)
                {
                    newLine = newWord;
                    start = 1;
                }
                else
                {
                    newLine = newLine + " " + newWord;
                }
            }
            Console.WriteLine(newLine);
        }
    }
}
