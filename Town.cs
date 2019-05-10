using System;
using System.Collections.Generic;

namespace Assessment3_Mock
{
    public class Town
    {

        public List<Villager> Villagers { get; set; }

        public Town()
        {

            Villagers = new List<Villager>();

            for (int i = 1; i < 4; i++)
            {
                Villagers.Add(new Slacker());
            }

            Villagers.Add(new Farmer());
        }

        public int Harvest()
        {
            int total = 0;

            foreach (Villager v in Villagers)
            {
                total += v.Farm();
            }

            return total;
        }

        public int CalcFoodConsumption()
        {
            int total = 0;

            foreach (Villager v in Villagers)
            {
                total += v.Hunger;
            }
            return total;
        }

        public bool SurviveTheWinter()
        {
            int harvest = Harvest();
            int calcFoodConsumption = CalcFoodConsumption();
            Console.WriteLine($"HARVEST = {harvest}");
            Console.WriteLine($"CONSUMP = {calcFoodConsumption}");
            Console.WriteLine();
            if (calcFoodConsumption <= harvest)
            {
                return true;
            }

            return false;
        }

    }

}
