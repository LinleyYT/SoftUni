﻿public class Citizen : ICitizen, IBirthable
{
    public Citizen(string name, int age, string id, string birthday)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthday = birthday;
    }

    public string Name { get; }
    public int Age { get; }
    public string Birthday { get; }
    public string Id { get; }
}
