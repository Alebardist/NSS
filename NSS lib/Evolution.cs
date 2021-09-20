namespace NSS_lib
{
    static class Evolution
    {
        public static void Evolute(OrganismPrototype organismExemplar, Environment environmentExemplar)
        {
            ChangeTemperatureResist(organismExemplar, environmentExemplar);
            ChangeSpeed(organismExemplar);
        }

        private static void ChangeTemperatureResist(OrganismPrototype organismExemplar, Environment environmentExemplar)
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
}
