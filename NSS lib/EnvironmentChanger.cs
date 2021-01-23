using System;

namespace Natural_Selection_SimulatorV2
{
    public class EnvironmentChanger : IEnvironmentChanger
    {
        private readonly Random _randomNumberGenerator = new Random();

        private int _temperatureChangeAmount;
        private int _foodAmountChange;

        public EnvironmentChanger(int temperatureChangeAmount, int foodAmountChange)
        {
            _temperatureChangeAmount = temperatureChangeAmount;
            _foodAmountChange = foodAmountChange;
        }

        public decimal ChangeTemperature()
        {
            if (_randomNumberGenerator.Next() == 0)
            {
                return _randomNumberGenerator.Next(-_temperatureChangeAmount, _temperatureChangeAmount);
            }
            else
            {
                return _randomNumberGenerator.Next(-_temperatureChangeAmount, _temperatureChangeAmount);
            }
        }

        //TODO: remake RAD generation algorithm
        public decimal ChangeRadiation()
        {
            if (_randomNumberGenerator.Next(0, 1) == 0)
            {
                return Convert.ToDecimal(_randomNumberGenerator.NextDouble());
            }
            return 0;
        }


        public int GenerateFood()
        {
            return _randomNumberGenerator.Next(_foodAmountChange / 2, _foodAmountChange);
        }




    }

}
