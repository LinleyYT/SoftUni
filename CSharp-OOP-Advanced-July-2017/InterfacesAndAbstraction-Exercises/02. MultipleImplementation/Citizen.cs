﻿public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    private string name;
    private int age;
    private string id;
    private string birthdate;

    public string Birthdate
    {
        get { return this.birthdate; }
        set { this.birthdate = value; }
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

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