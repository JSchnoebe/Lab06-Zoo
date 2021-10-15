using System;
namespace Zoo
{
    class Dog: Mammal
    {
        public Dog() : base("Dog")
        {
        }

        public override bool IsCarnivore => true;

        public override bool HaveClaws => true;

        public override bool HaveFur => true;


    }
}
