using System.Collections.Generic;
using System.Text;

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
        private  set { this.addOns = value; }
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.AddOns.Add(addOn);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        sb.AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");

        if (this.AddOns.Count > 0)
        {
            sb.Append($"Add-ons: {string.Join(", ", AddOns)}");
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }

        return sb.ToString();
    }
}

