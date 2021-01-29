namespace NSS_lib
{
    static class Evolution
    {
        public static void Evolute(OrganismPrototype organismExemplar, EnvironmentNss environmentExemplar)
        {
            ChangeTemperatureResist(organismExemplar, environmentExemplar);
            ChangeSpeed(organismExemplar);
        }

        private static void ChangeTemperatureResist(OrganismPrototype organismExemplar, EnvironmentNss environmentExemplar)
        {
            if (organismExemplar.MaxTempResist < environmentExemplar.Temperature)
            {
                organismExemplar.MaxTempResist += RandomIntGenerator.random.Next(0, 1);
                organismExemplar.MinTempResist--;
            }

            if (organismExemplar.MinTempResist > environmentExemplar.Temperature)
            {
                organismExemplar.MinTempResist += RandomIntGenerator.random.Next(0, 1);
                organismExemplar.MaxTempResist--;

            }
        }

        private static void ChangeSpeed(OrganismPrototype organismExemplar)
        {
            if (RandomIntGenerator.random.Next(1, 4) == 1)
            {
                organismExemplar.Speed = RandomIntGenerator.random.Next(1, 6);
            }
        }
    }

    static class Selection
    {
        public static void NaturalSelection(OrganismPrototype organism, EnvironmentNss envExmp)
        {
            if (envExmp.Temperature > organism.MaxTempResist || envExmp.Temperature < organism.MinTempResist) organism.Population--;
            if (envExmp.FoodAmount < organism.FoodConsumption*organism.Population) organism.Population--;

            //TODO: remake RAD reaction
            //if (envExmp.Radiation > organism.MaxRad) organism.Population += 2;
            if ( organism.Speed < 3 )
            {
                int eated = RandomIntGenerator.random.Next(0, 5);
                organism.Population -= eated;
                organism.EatedByPredators += eated;
            }
        }

    }



}
