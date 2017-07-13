using System.Text;

public class ShowCar : Car
{
    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
        this.Stars = 0;
    }

    private int stars;

    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public override void Tune(int tuneIndex, string addon)
    {
        this.Horsepower += tuneIndex;
        this.Suspension += tuneIndex / 2;
        this.Stars += tuneIndex;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Brand} {this.Model} {this.YearOfProduction}");
        sb.AppendLine($"{this.Horsepower} HP, 100 m/h in {this.Acceleration} s");
        sb.AppendLine($"{this.Suspension} Suspension force, {this.Durability} Durability");
        sb.Append($"{this.Stars} *");

        return sb.ToString();
    }
}


