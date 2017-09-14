using System;
using System.Text;

public abstract class Provider : SystemAll
{
    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    private double energyOutput;

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value >= 0 && value < 10000)
            {
                this.energyOutput = value;
            }
            else
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name.Substring(0, this.GetType().Name.Length - 8)} Provider - {this.Id}");
        sb.AppendLine($"Energy Output: {this.energyOutput}");

        return sb.ToString().Trim();
    }
}