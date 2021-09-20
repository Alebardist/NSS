namespace NSS_lib
{
    public class Launcher
    {
        public readonly OrganismPrototype organism;
        public readonly StatisticCollector statisticCollector;

        private readonly Environment _environment;
        private static EnvironmentChanger _changer;

        public Launcher(int userPopulation = 10, int tempResistRange = 10)
        {
            organism = new Organism(tempResistRange, -tempResistRange, userPopulation);
            statisticCollector = StatisticCollector.GetInstance();

            _changer = new EnvironmentChanger(10, 500);
            _environment = new Environment(300, 0, _changer);
        }
        
        public void Main()
        {
            while (true)
            {
                statisticCollector.CollectData(organism, _environment);
                if (organism.Population <= 1) break;

                _environment.EnvironmentCycle(organism);
                organism.IncreasePopulation(_environment);
                Selection.NaturalSelection(organism, _environment);
                Evolution.Evolute(organism, _environment);
            }
            StatisticCollector.ResetInstance();
        } 
    }
}