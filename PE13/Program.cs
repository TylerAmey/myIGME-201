using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace PE13
{

    public interface IDog
    {
        void Eat();
        void Play();
        void Bark();
        void NeedWalk();
        void GotoVet();

    }
    public interface ICat
    {
        void Eat();
        void Play();
        void Scratch();
        void Purr();

    }

    public class Pets
    {

        public List<Pet> petList = new List<Pet>();


        public Pet this[int nPetEl]
        {
            get
            {
                Pet returnVal;
                try
                {
                    returnVal = (Pet)petList[nPetEl];
                }
                catch
                {
                    returnVal = null;
                }

                return (returnVal);
            }

            set
            {
                // if the index is less than the number of list elements
                if (nPetEl < petList.Count)
                {
                    // update the existing value at that index
                    petList[nPetEl] = value;
                }
                else
                {
                    // add the value to the list
                    petList.Add(value);
                }
            }
        }

        public int Count
        {
            get { return petList.Count; }
        }

        public void Add(Pet pet)
        {
            petList.Add(pet);
        }

        public void Remove(Pet pet)
        {
            petList.Remove(pet);
        }

        public void RemoveAt(int petEl)
        {
            Pet pet = petList[petEl];
            petList.Remove(pet);
        }


    }

    public abstract class Pet
    {
        private string name;
        public int age;

        public string Name;

        public abstract void Eat();
        public abstract void Play();
        public abstract void GotoVet();

        public Pet(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    public class Dog : Pet, IDog
    {

        public string license;
        public string name;
        public int age;
        public Dog(string name, int age, string license):base(name,age)
        {
            this.age = age;
            this.name=name;
            this.license = license;
        }
        public virtual void Bark()
        {
            Console.WriteLine("Bark!");
        }

        public override void Eat()
        {
            Console.WriteLine(this.name + "eats their food!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.name + "doesn't wanna do to the vet!");
        }

        public virtual void NeedWalk()
        {
            Console.WriteLine(this.name + "needs a walk!");
        }

        public override void Play()
        {
            Console.WriteLine(this.name + "wants to play!");
        }


    }

    public class Cat : Pet, ICat
    {
        public string name;
        public int age;
        public Cat(string Name, int age):base(Name,age)
        {
            this.age = age;
            this.name = name;
        }
        public override void Eat()
        {
            Console.WriteLine(this.name + "eats their food!");
        }

        public override void GotoVet()
        {
            Console.WriteLine(this.name + "doesn't wanna do to the vet!");
        }

        public override void Play()
        {
            Console.WriteLine(this.name + "wants to play!");
        }

        public virtual void Purr()
        {
            Console.WriteLine("Purrrr");
        }

        public virtual void Scratch()
        {
            Console.WriteLine(this.name + "scratches!");
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog iDog = null;
            ICat iCat = null;

            Pets pets = new Pets();

            Random rand = new Random();
            int petCount = 0;
            for (int i = 0; i < 50; i++)
            {

                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("You got a dog! What are you gonna name it?");
                        string name = Console.ReadLine();
                        Console.WriteLine("How old is it?");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("What license does it have?");
                        string license = Console.ReadLine();
                        dog = new Dog(name, age, license);
                        pets.Add(dog);
                        petCount++;
                    }
                    else
                    {
                        Console.WriteLine("You got a cat! What are you gonna name it?");
                        string name = Console.ReadLine();
                        Console.WriteLine("How old is it?");
                        int age = int.Parse(Console.ReadLine());
                        cat = new Cat(name, age);
                        pets.Add(cat);
                        petCount++;
                    }
                }
                else
                {
                    if (petCount == 0)
                    {
                        continue;
                    }
                    else
                    {

                        Pet randomPet = pets[rand.Next(0, pets.Count)];
                        if (randomPet.GetType().Equals(typeof(Dog)))
                        {
                            int nAction = rand.Next(1, 6);
                            iDog = (Dog)randomPet;
                            if (nAction == 1)
                            {
                                iDog.Play();
                            }
                            if (nAction == 2)
                            {
                                iDog.Eat();
                            }
                            if (nAction == 3)
                            {
                                iDog.GotoVet();
                            }
                            if (nAction == 4)
                            {
                                iDog.Bark();
                            }
                            if (nAction == 5)
                            {
                                iDog.NeedWalk();
                            }
                        }
                        else
                        {
                            int nAction = rand.Next(1, 6);
                            iCat = (Cat)randomPet;
                            if (nAction == 1)
                            {
                                iCat.Play();
                            }
                            if (nAction == 2)
                            {
                                iCat.Eat();
                            }
                            if (nAction == 3)
                            {
                                iCat.GotoVet();
                            }
                            if (nAction == 4)
                            {
                                iCat.Purr();
                            }
                            if (nAction == 5)
                            {
                                iCat.Scratch();
                            }
                        }
                    }
                }
            }

        }
    }
}
