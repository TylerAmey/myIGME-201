using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundFunction
{
    internal class Program
    {

        delegate double MyRound(double nToRound, int nPlaces);
        static void Main(string[] args)
        {
            MyRound myRound;

            myRound = new MyRound(Math.Round);

            double result = myRound(23.297197, 2);

            Console.WriteLine(result);

        }
    }
}
