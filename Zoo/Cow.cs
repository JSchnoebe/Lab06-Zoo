using System;
namespace Zoo
{
    class Cow : Mammal
    {

        public Cow(string name) : base(name)
        {
        }

        public override bool IsCarnivore => false;

        public override bool HaveClaws => false;

        public override bool HaveFur => true;
    }
}
