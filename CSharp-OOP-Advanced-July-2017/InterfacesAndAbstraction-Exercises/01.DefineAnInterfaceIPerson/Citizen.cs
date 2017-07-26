public class Citizen : IPerson
{
    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    private string name;
    private int age;

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
}