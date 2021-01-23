using System;

namespace Natural_Selection_SimulatorV2
{
    public class EnvironmentNss : IEnvironmentNss
    {
        public int FoodAmount { get; private set; }
        public decimal Temperature { get; private set; }
        public decimal Radiation { get; private set; }

        private readonly EnvironmentChanger _changer;
        public EnvironmentNss(int startFood, decimal startTemperature, EnvironmentChanger changerExemplar)
        {
            FoodAmount = startFood;
            Temperature = startTemperature;
            _changer = changerExemplar;

        }

        // EnvironmentCycle
        public void EnvironmentCycle(Organism organismExmp)
        {
            Temperature += _changer.ChangeTemperature();
            FoodAmount += _changer.GenerateFood();
            FoodAmount -= organismExmp.FoodConsumption * organismExmp.Population;
            Radiation += _changer.ChangeRadiation();


        }




    }
}
