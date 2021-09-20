using System;

namespace NSS_lib
{
    public class EnvironmentChanger : IEnvironmentChanger
    {
        private readonly int _temperatureChangeAmount;
        private readonly int _foodAmountChange;

        public EnvironmentChanger(int temperatureChangeAmount, int foodAmountChange)
        {
            _temperatureChangeAmount = temperatureChangeAmount;
            _foodAmountChange = foodAmountChange;
        }

        public decimal ChangeTemperature()
        {
            if (RandomIntGenerator.random.Next(2) == 0)
            {
                return RandomIntGenerator.random.Next(-_temperatureChangeAmount, _temperatureChangeAmount);
            }

            return 0;
        }

        public decimal ChangeRadiation()
        {
            if (RandomIntGenerator.random.Next(0, 3) == 0)
            {
                return Convert.ToDecimal(RandomIntGenerator.random.NextDouble());
            }

            return 0;
        }

        public int GenerateFood()
        {
            return RandomIntGenerator.random.Next(_foodAmountChange / 1, _foodAmountChange);
        }
    }
}
