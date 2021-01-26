using System.Collections.Generic;

namespace NSS_lib
{
    public class StatisticCollector
    {
        // props
        public int DaysPassed { get; private set; }
        public int CurrentFoodAmount { get; private set; }
        public int EatedByPredators { get; private set; }
        public decimal Radiation { get; private set; }

        private int _maxPopulation;

        // props lists
        public List<decimal> PopulationList { get; } = new List<decimal>();
        public List<decimal> Temperature { get; } = new List<decimal>();
        public List<decimal> Speed { get; } = new List<decimal>();

        public int MaxPopulation
        {
            get => _maxPopulation;
            set
            {
                if (_maxPopulation < value) _maxPopulation = value;
            }
        }


        public void CollectData(OrganismPrototype organism, EnvironmentNss environment)
        {
            DaysPassed++;
            //for preventing overflow exception
            //if (DaysPassed == 500) throw new System.StackOverflowException();

            MaxPopulation = organism.Population;
            PopulationList.Add(organism.Population);
            Temperature.Add(environment.Temperature);
            CurrentFoodAmount = environment.FoodAmount;
            Speed.Add(organism.Speed);
            EatedByPredators = organism.EatedByPredators;
            Radiation = environment.Radiation;
        }
    }
}
