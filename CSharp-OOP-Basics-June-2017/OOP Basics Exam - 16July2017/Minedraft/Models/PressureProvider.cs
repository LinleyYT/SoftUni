public class PressureProvider : Provider
{
    public const double EnergyOutputMod = 50;

    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput += (energyOutput * EnergyOutputMod) / 100;
    }
}