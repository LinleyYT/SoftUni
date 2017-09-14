public class FireMonument : Monument
{
    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
    }

    private int fireAffinity;

    public int FireAffinity
    {
        get { return this.fireAffinity; }
        set { this.fireAffinity = value; }
    }

    public override string ToString()
    {
        return $"Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity}";
    }

    public override int CalculateMonumentPoints()
    {
        return this.FireAffinity;
    }
}