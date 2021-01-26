namespace NSS_lib
{
    public interface IEnvironmentNss
    {
        int FoodAmount { get; }
        decimal Radiation { get; }
        decimal Temperature { get; }

        void EnvironmentCycle(OrganismPrototype organismExmp);
    }
}