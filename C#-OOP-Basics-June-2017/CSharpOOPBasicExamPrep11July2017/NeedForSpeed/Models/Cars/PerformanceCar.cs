using System.Collections.Generic;

public class PerformanceCar : Car
{
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = base.Horsepower + (int)(base.Horsepower * HorsepoweMod);
        this.Acceleration = acceleration;
        this.Suspension = base.Suspension - (int)(base.Suspension * SuspensionMod);
        this.Durability = durability;
        this.AddOns = new List<string>();
    }

    private const double HorsepoweMod = 0.5;
    private const double SuspensionMod = 0.25;

    private List<string> addOns;

    public List<string> AddOns
    {
        get { return this.addOns; }
        set { this.addOns = value; }
    }

    public override string ToString()
    {
        return "";
    }
}

