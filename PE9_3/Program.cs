using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_3
{
    static class Program
    {

        delegate string lineReader(string input);
        
        static void Main(string[] args)
        {

            lineReader line;
            line = new lineReader(ReadInput);

            string ReadInput(string input)
            {
                return input;
            }
        }
    }
}
