using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwelve
{
    static internal class Program
    {
        static string sName;
        static double dSalary = 30000;
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            sName = Console.ReadLine();
            bool bCongrats = GiveRaise(sName, ref dSalary);
            if (bCongrats == true)
            {
                Console.WriteLine("Congratulations " + sName + ", you've been promoted! Your new salary is " + dSalary + "!");
            }
            else
            {
                Console.WriteLine("Sorry " + sName + ", you did not recieve a raise"); 
            }
        }

        static bool GiveRaise(string name, ref double salary)
        {
            if(name == "Tyler Amey")
            {
                dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
