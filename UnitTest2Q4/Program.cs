using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2Q4
{
    
    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();

    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber()
        {
            return this.phoneNumber;
        }

        public abstract void Connect();

        public abstract void Disconnect();
    }


    public class RotaryPhone : Phone, PhoneInterface
    {
        public override void Connect()
        {
            Console.WriteLine("rotary connected");
        }

        public override void Disconnect()
        {
            Console.WriteLine("rotary disconnected");
        }

        public virtual void HangUp()
        {
            Console.WriteLine("rotary hang up");
        }

        public virtual void MakeCall()
        {
            Console.WriteLine("rotary make a call");
        }

        public virtual void Answer()
        {
            Console.WriteLine("rotary answer phone");
        }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public override void Connect()
        {
            Console.WriteLine("push button connected");
        }

        public override void Disconnect()
        {
            Console.WriteLine("push button disconnected");
        }

        public virtual void HangUp()
        {
            Console.WriteLine("push button hang up");
        }

        public virtual void MakeCall()
        {
            Console.WriteLine("push button make a call");
        }

        public virtual void Answer()
        {
            Console.WriteLine("push button answer phone");
        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewDriver;
        private byte whichDrWho;
        private string femaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }

        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public void TimeTravel()
        {
            Console.WriteLine("Time travel");
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {
            Console.WriteLine("Opens door");
        }

        public void CloseDoor()
        {
            Console.WriteLine("Closes door");
        }
    }


}
