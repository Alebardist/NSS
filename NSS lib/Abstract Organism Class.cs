using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natural_Selection_SimulatorV2
{
    public abstract class OrganismPrototype
    {
        //props
        public abstract decimal MaxTempResist { get; set; }
        public abstract decimal MinTempResist { get; set; }

        public abstract int Speed
        {
            get;
            set;
        }

        public abstract int Population
        {
            get;
            set;
        }
        public abstract int FoodConsumption
        {
            get;
            set;
        }
        public abstract int EatedByPredators
        {
            get;
            set;
            
        }
        public abstract int MaxRad { get; set; }

        public abstract void PopulationExtension(EnvironmentNss envExmp);
    }
}
