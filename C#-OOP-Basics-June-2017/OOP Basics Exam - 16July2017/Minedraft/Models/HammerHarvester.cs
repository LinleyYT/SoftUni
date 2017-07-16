public class HammerHarvester : Harvester
{
    public const double OreOutputMod = 200;
    public const double EnergyRequirementMod = 100;

    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += (oreOutput * OreOutputMod) / 100;
        this.EnergyRequirement += (energyRequirement * EnergyRequirementMod) / 100;
    }
}

