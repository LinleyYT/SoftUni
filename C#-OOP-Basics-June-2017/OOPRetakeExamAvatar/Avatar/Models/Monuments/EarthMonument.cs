public class EarthMonument : Monument
{
    public EarthMonument(string name, int earthAffinity)
    : base(name)
    {
        this.EarthAffinity = earthAffinity;
    }

    private int earthAffinity;

    public int EarthAffinity
    {
        get { return this.earthAffinity; }
        set { this.earthAffinity = value; }
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
    }

    public override int CalculateMonumentPoints()
    {
        return this.EarthAffinity;
    }
}

