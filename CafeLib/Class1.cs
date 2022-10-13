using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;


namespace CafeLib
{
    public interface IMood
    {
        string Mood { get; }
    }

    public interface ITakeOrder
    {
        void TakeOrder();
    }

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get;
        }
    }

    public class Waiter : IMood
    {
        public string name;

        public string Mood
        {
            get;
        }

        public void ServeCustomer(HotDrink cup)
        {
            //Serve the customer
        }
    }

    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public HotDrink()
        {
            this.instant = false;
            this.milk = false;
            this.sugar = 0;
            this.size = "medium";

            this.customer = new Customer();
        }

        public HotDrink(string brand)
        {
            // Folgers is instant coffee
            if (brand == "Folgers")
            {
                this.instant = true;
            }

            this.milk = false;
            this.sugar = 0;
            this.size = "medium";

            this.customer = new Customer();
        }


        public virtual void AddSugar(byte amount)
        {
            sugar += amount;
        }

        public abstract void Steam();

    }

    public class CupOfCoffee : HotDrink, ITakeOrder
    {
        public string beanType;

        public CupOfCoffee(string brand) : base(brand)
        {
            if (brand == "Folgers")
            {
                this.beanType = "rancid";
            }
        }

        public override void Steam()
        {
            //
        }

        public void TakeOrder()
        {
            //
        }
    }

    public class CupOfTea : HotDrink, ITakeOrder
    {
        public string leafType;

        public CupOfTea(bool customerIsWealthy)
        {
            if (customerIsWealthy == true)
            {
                this.leafType = "pure";
            }
        }

        public override void Steam()
        {
            //
        }

        public void TakeOrder()
        {
            //
        }
    }

    public class CupOfCocoa : HotDrink, ITakeOrder
    {
        private string source;
        public bool marshmallows;
        public static int numCuups;
        public string Source
        {
            set { source = value; }
        }


        public CupOfCocoa() : this(false)
        {

        }

        public CupOfCocoa(bool marshmallows) : base("Expensive Organic Brand")
        {
            if (marshmallows == true)
            {
                this.source = "Expensive Organic Brand";
            }
        }

        public override void AddSugar(byte amount)
        {
            base.AddSugar(amount);
        }

        public override void Steam()
        {
            //
        }

        public void TakeOrder()
        {
            //
        }
    }





}
