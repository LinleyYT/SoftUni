public abstract class Monument
{
    public Monument(string name)
    {
        this.Name = name;
    }

    private string name;

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public abstract int CalculateMonumentPoints();
}