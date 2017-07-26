public abstract class SystemAll
{
    protected SystemAll(string id)
    {
        this.id = id;
    }

    private string id;

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
}

