using System;
namespace Assessment3_Mock
{
    public class Farmer : Villager
    {
        public Farmer()
        {
            Hunger = 1;
        }

        public override int Farm()
        {
            return 2;
        }
    }
}
