using System;

namespace NSS_lib
{
    public class Organism : OrganismPrototype
    {
        public const int _populationExtensionModificator = 4;

        //props
        public override decimal MaxTempResist
        {
            get => _maxTempResist;
            set => _maxTempResist = value;
        }
        public override decimal MinTempResist
        {
            get => _minTempResist;
            set => _minTempResist = value;
        }

        public override int Speed
        {
            get => _speed;
            set
            {
                if (value > 0) _speed = value;
            }
        }

        public override int Population
        {
            get => _population;
            set
            {
                if (value >= 0) _population = value;
            }
        }
        public override int FoodConsumption
        {
            get => _foodConsumption;
            set
            {
                if (value > 0) _foodConsumption = value;
            }
        }
        public override int EatedByPredators
        {
            get => _eatedByPredators;
            set
            {
                if (value >= 0) _eatedByPredators = value;
            }
        }
        public override int MaxRad { get; protected set; } = 0;

        //private fields
        private decimal _maxTempResist;
        private decimal _minTempResist;
        private int _speed;
        private int _population;
        private int _foodConsumption;
        private int _eatedByPredators;

        public Organism(decimal maxTempResist, decimal minTempResist, int speed = 2, int population = 10, int foodConsumption = 2)
        {
            MaxTempResist = maxTempResist;
            MinTempResist = minTempResist;
            Speed = speed;
            Population = population;
            FoodConsumption = foodConsumption;
        }

        public override void IncreasePopulation(Environment envExmp)
        {
            if (envExmp.FoodAmount > FoodConsumption) Population += RandomIntGenerator.random.Next(0, _population / _populationExtensionModificator);
        }
    }
}