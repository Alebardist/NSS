namespace Natural_Selection_SimulatorV2
{
    public interface IEnvironmentNss
    {
        int FoodAmount { get; }
        decimal Radiation { get; }
        decimal Temperature { get; }

        void EnvironmentCycle(Organism organismExmp);
    }
}