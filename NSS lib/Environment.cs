﻿namespace NSS_lib
{
    public class Environment : IEnvironment
    {
        public int FoodAmount { get; private set; }
        public decimal Temperature { get; private set; }
        public decimal Radiation { get; private set; }

        private readonly EnvironmentChanger _changer;

        public Environment(int startFood, decimal startTemperature, EnvironmentChanger changerExemplar)
        {
            FoodAmount = startFood;
            Temperature = startTemperature;
            _changer = changerExemplar;

        }

        public void EnvironmentCycle(OrganismPrototype organismExmp)
        {
            Temperature += _changer.ChangeTemperature();
            FoodAmount += _changer.GenerateFood();
            FoodAmount -= organismExmp.FoodConsumption * organismExmp.Population;
            Radiation += _changer.ChangeRadiation();
        }
    }
}
