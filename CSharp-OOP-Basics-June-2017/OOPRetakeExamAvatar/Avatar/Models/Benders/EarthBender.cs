public class EarthBender : Bender
{
    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    private double groundSaturation;

    public double GroundSaturation
    {
        get { return this.groundSaturation; }
        set { this.groundSaturation = value; }
    }

    public override string ToString()
    {
        return $"Earth Bender: {this.Name}, Power: {this.Power}, Ground Saturation: {this.GroundSaturation:f2}";
    }

    public override double CalculatePower()
    {
        return this.Power * this.GroundSaturation;
    }
}