using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass1
{
    public class MyClass
    {
        static private string myString;

        public string MyString
        {
            set { myString = value; }
        }

        public virtual string GetString()
        {
            return myString;
        }
    }
}
