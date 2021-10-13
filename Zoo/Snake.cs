using System;
namespace Zoo
{
    class Snake : Reptile
    {
        public Snake(string species) : base(species)
        {
        }

        public override int LegCount => 0;

        public override bool IsCarnivore => true;

        public override bool HaveScales => true;

        public override bool HaveSharpTeeth => true;
    }
}
