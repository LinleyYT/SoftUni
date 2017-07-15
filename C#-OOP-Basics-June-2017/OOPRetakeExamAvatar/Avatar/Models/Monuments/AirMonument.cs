public class AirMonument : Monument
{
    public AirMonument(string name, int airAffinity) 
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    private int airAffinity;

    public int AirAffinity
    {
        get { return this.airAffinity; }
        set { this.airAffinity = value; }
    }

    public override string ToString()
    {
        return $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
    }

    public override int CalculateMonumentPoints()
    {
        return this.AirAffinity;
    }
}

