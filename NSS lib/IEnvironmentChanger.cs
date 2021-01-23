namespace Natural_Selection_SimulatorV2
{
    public interface IEnvironmentChanger
    {
        decimal ChangeRadiation();
        decimal ChangeTemperature();
        int GenerateFood();
    }
}