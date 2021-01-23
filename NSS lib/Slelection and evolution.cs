using System;


namespace Natural_Selection_SimulatorV2
{
    static class Evolution
    {
        private readonly static Random _randomNumberGenerator = new Random();

        public static void Evolute(Organism organismExemplar, EnvironmentNss environmentExemplar)
        {
            ChangeTemperatureResist(organismExemplar, environmentExemplar);
            ChangeSpeed(organismExemplar);
        }

        private static void ChangeTemperatureResist(Organism organismExemplar, EnvironmentNss environmentExemplar)
        {
            if (organismExemplar.MaxTempResist < environmentExemplar.Temperature)
            {
                organismExemplar.MaxTempResist += _randomNumberGenerator.Next(0, 1);
                organismExemplar.MinTempResist--;
            }

            if (organismExemplar.MinTempResist > environmentExemplar.Temperature)
            {
                organismExemplar.MinTempResist += _randomNumberGenerator.Next(0, 1);
                organismExemplar.MaxTempResist--;

            }
        }

        private static void ChangeSpeed(Organism organismExemplar)
        {
            if (_randomNumberGenerator.Next(1, 4) == 1)
            {
                organismExemplar.Speed = _randomNumberGenerator.Next(1, 6);
            }
        }
    }

    static class Selection
    {
        private readonly static Random _randomNumberGenerator = new Random();

        public static void NaturalSelection(Organism organism, EnvironmentNss envExmp)
        {
            if (envExmp.Temperature > organism.MaxTempResist || envExmp.Temperature < organism.MinTempResist) organism.Population--;
            if (envExmp.FoodAmount < organism.FoodConsumption*organism.Population) organism.Population--;

            //TODO: remake RAD reaction
            //if (envExmp.Radiation > organism.MaxRad) organism.Population += 2;
            if ( organism.Speed < 3 )
            {
                int eated = _randomNumberGenerator.Next(0, 5);
                organism.Population -= eated;
                organism.EatedByPredators += eated;
            }
        }

    }



}
