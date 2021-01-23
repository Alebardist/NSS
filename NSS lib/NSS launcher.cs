using System;

//TODO: ! add abstract classes for other classes
namespace Natural_Selection_SimulatorV2
{
    public class Launcher
    {
        public readonly Organism organism;
        public readonly StatisticCollector statisticCollector;

        private EnvironmentNss environmentObject;
        private static EnvironmentChanger changer;

        public Launcher( int population = 10, int tempResistRange = 10 )
        {
            organism = new Organism(tempResistRange, -tempResistRange, 2, population);
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