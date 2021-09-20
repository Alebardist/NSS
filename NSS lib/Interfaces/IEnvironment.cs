namespace NSS_lib
{
    public interface IEnvironment
    {
        int FoodAmount { get; }
        decimal Radiation { get; }
        decimal Temperature { get; }

        void EnvironmentCycle(OrganismPrototype organismExmp);
    }
}