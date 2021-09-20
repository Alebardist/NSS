namespace NSS_lib
{
    public abstract class OrganismPrototype
    {
        //props
        public abstract decimal MaxTempResist { get; set; }
        public abstract decimal MinTempResist { get; set; }
        public abstract int Speed { get; set; }
        public abstract int Population {  get; set; }
        public abstract int FoodConsumption {  get; set; }
        public abstract int EatedByPredators {  get; set; }
        public abstract int MaxRad { get; protected set; }

        public abstract void IncreasePopulation(Environment environment);
    }
}