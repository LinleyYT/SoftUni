public class FireBender : Bender
{
    public FireBender(string name, int power, double heatAggression) 
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    private double heatAggression;

    public double HeatAggression
    {
        get { return this.heatAggression; }
        set { this.heatAggression = value; }
    }

    public override string ToString()
    {
        return $"Fire Bender: {this.Name}, Power: {this.Power}, Heat Aggression: {this.HeatAggression:f2}";
    }

    public override double CalculatePower()
    {
        return this.Power * this.HeatAggression;
    }
}

