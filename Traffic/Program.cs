using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesReal;

namespace Traffic
{
    internal class Program
    {

        static void AddPassenger(VehiclesReal.IPassengerCarrier passenger)
        {
            passenger.LoadPassenger();
            Console.WriteLine(passenger.ToString());
        }


        static void Main(string[] args)
        {
        }
    }
}
