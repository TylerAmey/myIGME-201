using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fart
{
    public sealed class Circus
    {
        public string name;
    }


    static class Program
    {
        static void Main()
        {

            Circus myCircus = new Circus();
            myCircus.name = "Joe";
            Console.WriteLine(myCircus.name);
        }
    }

}
