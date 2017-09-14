public class SonicHarvester : Harvester
{
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        this.EnergyRequirement = energyRequirement / sonicFactor;
    }

    private int sonicFactor;

    public int SonicFactor
    {
        get { return this.sonicFactor; }
        set { this.sonicFactor = value; }
    }
}