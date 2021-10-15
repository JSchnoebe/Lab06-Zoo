using System;
namespace Zoo
{
    class Dolphin : Mammal
    {
        public Dolphin(string species) : base(species)
        {
        }

        public override bool IsCarnivore => true;

        public override bool HaveClaws => false;

        public override bool HaveFur => false;
    }
}
