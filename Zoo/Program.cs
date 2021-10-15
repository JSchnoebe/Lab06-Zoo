using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the zoo!");
            Console.WriteLine("--------------------");

            Dog dog = new Dog();
            dog.Color = "Brown";
            dog.PrintSummary();

            Console.WriteLine("--------------------");

            Cow cow = new Cow("Beef Cow");
            cow.Color = "Black";
            cow.PrintSummary();

            Console.WriteLine("--------------------");

            Dolphin dol = new Dolphin("Bottle Nosed Dolphin");
            dol.Color = "Gray";
            dol.PrintSummary();

            Console.WriteLine("--------------------");

            Snake snk = new Snake("Cobra");
            snk.Color = "Black";
            snk.PrintSummary();


            Console.WriteLine("Mammals!");
            Mammal[] mammal = new Mammal[]
            {
                dog,
                new Cow("Dairy Cow"),
                new Cow("Beef Cow"),

            };

            Reptile[] reptile = new Reptile[]
            {
                snk,

            };
        }
    }

    abstract class Animal
    {
        public string Species { get; protected set; }

        public string Color { get; set; }

        public abstract bool IsCarnivore { get; }

        public void PrintSummary()
        {
            Console.WriteLine("Animal Species: {0}", Species);
            Console.WriteLine("Animal Color: {0}", Color);
            Console.WriteLine("Carnivor? {0}", IsCarnivore);
        }
    }

    abstract class Mammal : Animal
    {
        public virtual bool HaveClaws { get { return true; } }

        public override bool IsCarnivore => true;

        public virtual bool HaveFur { get; }

        public Mammal(string species)
        {
            Species = species;
        }
    }

    abstract class Reptile : Animal
    {
        public virtual int LegCount { get { return 4; } }

        public virtual bool HaveSharpTeeth { get; }

        public virtual bool HaveScales { get; }

        public Reptile(string species)
        {
            Species = species;
        }
    }
}
