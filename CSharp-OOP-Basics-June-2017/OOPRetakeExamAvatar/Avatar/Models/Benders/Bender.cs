﻿public abstract class Bender
{
    public Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    private string name;
    private int power;

    public int Power
    {
        get { return this.power; }
        protected set { this.power = value; }
    }

    public string Name
    {
        get { return this.name; }
        protected set { this.name = value; }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.Name}, Power: {this.Power},";
    }

    public abstract double CalculatePower();
}