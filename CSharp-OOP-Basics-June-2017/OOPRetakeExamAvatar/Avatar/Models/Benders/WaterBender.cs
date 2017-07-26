public class WaterBender : Bender
{
    public WaterBender(string name, int power, double waterClarity) 
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    private double waterClarity;

    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public override string ToString()
    {
        return $"Water Bender: {this.Name}, Power: {this.Power}, Water Clarity: {this.WaterClarity:f2}";
    }

    public override double CalculatePower()
    {
        return this.Power * this.WaterClarity;
    }
}

