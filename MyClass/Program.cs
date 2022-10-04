using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class MyClass
    {
        static private string myString;

        public string MyString
        {
            set { myString = value; }
        }

        static public string GetString()
        {
            return myString;
        }

        static void Main(string[] args)
        {
        }
    }
}
