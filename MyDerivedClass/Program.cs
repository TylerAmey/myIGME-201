using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClass1;

namespace MyDerivedClass
{
    public class MyDerivedClass : MyClass
    {

        public override string GetString()
        {
            return base.GetString();
        }

        static void Main(string[] args)
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass();
            myDerivedClass.MyString = "My String";
            Console.WriteLine(myDerivedClass.GetString());

            
        }
    }
}
