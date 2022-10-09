using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    public abstract class AbstractClass
    {
        private string name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    public interface Inter
    {
        void StateName();
    }

    public class ClassOne : Inter
    {
        public virtual void StateName()
        {
            Console.WriteLine("My name is Class One!");
        }
    }

    public class ClassTwo : Inter
    {
        public virtual void StateName()
        {
            Console.WriteLine("My name is Class Two!");
        }
    }
    internal class MainClass
    {
        public static void MyMethod(object myObject)
        {
            Inter inter = (Inter)myObject;
            inter.StateName();
        }

        public void Main(String[] args)
        {
            ClassOne classOne = new ClassOne();
            ClassTwo classTwo = new ClassTwo();
            MyMethod(classOne);
            MyMethod(classTwo);
        }
    }
}
