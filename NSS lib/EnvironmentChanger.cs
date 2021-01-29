using System;

namespace NSS_lib
{
    public class EnvironmentChanger : IEnvironmentChanger
    {
        private int _temperatureChangeAmount;
        private int _foodAmountChange;

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
            else
            {
                return RandomIntGenerator.random.Next(-_temperatureChangeAmount, _temperatureChangeAmount);
            }
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
