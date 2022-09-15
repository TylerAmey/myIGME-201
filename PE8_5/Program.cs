using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,,] array = new double[40,40,40];
            int arrayCounter = 0;
            for(double x = -1; x <=1; x = x + 0.1)
            {
                for (double y = 1; y <= 4; y = y + 0.1)
                {
                    double z = (3 * (Math.Pow(y, 2))) + (2 * x) - 1;
                    array[arrayCounter, arrayCounter, arrayCounter] = [x, y, z];
                }
            } 


        }
    }
}
