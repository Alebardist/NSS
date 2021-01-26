namespace NSS_lib
{
    public class Launcher
    {
        public readonly OrganismPrototype organism;
        public readonly StatisticCollector statisticCollector;
        private EnvironmentNss environmentObject;
        private static EnvironmentChanger changer;

        public Launcher( int UserPopulation = 10, int tempResistRange = 10 )
        {
            organism = new Organism(tempResistRange, -tempResistRange, population: UserPopulation);
            changer = new EnvironmentChanger(10, 100);

            environmentObject = new EnvironmentNss(300, 0, changer);
            statisticCollector = new StatisticCollector();
        }
        
        public void Main()
        {
            while (true)
            {
                statisticCollector.CollectData(organism, environmentObject);
                if (organism.Population <= 1) break;

                environmentObject.EnvironmentCycle(organism);
                organism.PopulationExtension(environmentObject);
                Selection.NaturalSelection(organism, environmentObject);
                Evolution.Evolute(organism, environmentObject);
            }

        } 
    }
}