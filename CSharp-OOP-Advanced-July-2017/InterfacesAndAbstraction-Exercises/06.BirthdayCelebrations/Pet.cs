public class Pet : IPet, IBirthable
{
    public Pet(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public string Name { get; }
    public string Birthday { get; }
}