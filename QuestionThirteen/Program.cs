using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThirteen
{
    internal class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            employee employee = new employee();
            employee.sName = Console.ReadLine();
            employee.dSalary = 30000;
            bool bCongrats = GiveRaise(employee);
            if (bCongrats == true)
            {
                Console.WriteLine("Congratulations " + employee.sName + ", you've been promoted! Your new salary is " + employee.dSalary + "!");
            }
            else
            {
                Console.WriteLine("Sorry " + employee.sName + ", you did not recieve a raise");
            }
        }

        static bool GiveRaise(employee employee)
        {
            if (employee.sName == "Tyler Amey")
            {
                employee.dSalary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
