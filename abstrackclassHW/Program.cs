using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrackclassHW
{
    public abstract class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public abstract void Run();
        public abstract void Walk();
        public virtual void PrintWhoIsIt()
        {
            Console.WriteLine(Name);
        }
        public string GetName()
        {
            return Name;
        }
    }
    public class Child : Person
    {

        public int YearOfBirth{ get; set; }
        public Child(string name, int year) : base(name)
        {
            YearOfBirth = year;
        }

        public override void PrintWhoIsIt()
        {
            Console.WriteLine("This is Child " + Name);
        }

        public override void Run()
        {
            Console.WriteLine("Child is running");
        }

        public override void Walk()
        {
            Console.WriteLine("Child is walking");
        }
    }
    class Teenager : Person
    {
        public int AmountOfAcnes { get; set; }
        public Teenager(string name, int acnes) : base(name)
        {
            AmountOfAcnes = acnes;
        }

        public override void PrintWhoIsIt()
        {
            Console.WriteLine("This is Teenager " + Name);
        }

        public override void Run()
        {
            Console.WriteLine("Teenager is runing");
        }

        public override void Walk()
        {
            Console.WriteLine("Teenager is walking");
        }
    }
    class OldMan : Person
    {
        public int Age { get; set; }
        public OldMan (string name) : base(name)
        {
        }

        public override void PrintWhoIsIt()
        {
            Console.WriteLine("This is Oldman " + Name);
        }

        public override void Run()
        {
            Console.WriteLine("Oldman is runing");
        }

        public override void Walk()
        {
            Console.WriteLine("Oldman is walking");
        }
    }

    class Dead : Person
    {
        public int YearOfDeath  {get; set; }
        public string  WhayCanYouSayAboutDead { get; set; }
        public Dead (string name) : base(name)
        {

        }

        public override void PrintWhoIsIt()
        {
            Console.WriteLine("This is Dead " + Name + ", he died in " +YearOfDeath+ " year. " + WhayCanYouSayAboutDead);
        }

        public override void Run()
        {
            Console.WriteLine("Dead isn't runing");
        }

        public override void Walk()
        {
            Console.WriteLine("Dead isn't walking");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var child = new Child("Ivan",2018);
            Console.WriteLine(child.GetName());
            child.PrintWhoIsIt();
            var dead = new Dead("Bolvan")
            {
                YearOfDeath = 2018,
                WhayCanYouSayAboutDead = "He was very cool! "
                
            };
            Console.WriteLine(dead.GetName());
            dead.Walk();
            dead.PrintWhoIsIt();

        }
    }
}
