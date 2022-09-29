using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesReal
{
    public class Vehicle
    {
        public virtual void LoadPassenger() { }
    }

    public class Car : Vehicle
    {

    }

    public class Train : Vehicle
    {

    }

    public class Compact : Car, IPassengerCarrier
    {

    }

    public class SUV : Car, IPassengerCarrier
    {

    }

    public class Pickup : Car, IPassengerCarrier
    {

    }

    public class PassengerTrain : Train, IHeavyLoadCarrier
    {

    }

    public class FreightTrain : Train, IHeavyLoadCarrier
    {

    }

    public class _424DoubleBogey : Train, IHeavyLoadCarrier
    {

    }

    public interface IPassengerCarrier
    {
        void LoadPassenger();
    }

    public interface IHeavyLoadCarrier
    {

    }
}
