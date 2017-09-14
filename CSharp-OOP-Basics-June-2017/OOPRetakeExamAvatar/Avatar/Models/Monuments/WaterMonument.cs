public class WaterMonument : Monument
{
    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
    }

    private int waterAffinity;

    public int WaterAffinity
    {
        get { return this.waterAffinity; }
        set { this.waterAffinity = value; }
    }

    public override string ToString()
    {
        return $"Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
    }

    public override int CalculateMonumentPoints()
    {
        return this.WaterAffinity;
    }
}