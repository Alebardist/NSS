namespace NSS_lib
{
    internal static class Selection
    {
        public static void NaturalSelection(OrganismPrototype organism, Environment envExmp)
        {
            if (envExmp.Temperature > organism.MaxTempResist || envExmp.Temperature < organism.MinTempResist) organism.Population--;
            if (envExmp.FoodAmount < organism.FoodConsumption * organism.Population) organism.Population--;

            //TODO: remake RAD reaction
            if (organism.Speed < 3)
            {
                int eated = RandomIntGenerator.random.Next(0, 5);
                organism.Population -= eated;
                organism.EatedByPredators += eated;
            }
        }
    }
}
