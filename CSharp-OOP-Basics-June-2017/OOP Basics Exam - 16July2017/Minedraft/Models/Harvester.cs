using System;
using System.Text;

public abstract class Harvester : SystemAll
{
    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.Id = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    private double oreOutput;
    private double energyRequirement;

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value >= 0)
            {
                this.oreOutput = value;
            }
            else
            {
                throw new ArgumentException("Harvester is not registered, because of it's OreOutput");
            }
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value >= 0 && value <= 20000)
            {
                this.energyRequirement = value;
            }
            else
            {
                throw new ArgumentException("Harvester is not registered, because of it's EnergyRequirement");
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.GetType().Name.Substring(0, this.GetType().Name.Length - 9)} Harvester - {this.Id}");
        sb.AppendLine($"Ore Output: {this.OreOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return sb.ToString().Trim();
    }
}