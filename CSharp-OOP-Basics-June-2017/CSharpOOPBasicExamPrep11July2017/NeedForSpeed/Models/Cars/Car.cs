public abstract class Car
{
    public Car(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension,
        int durability)
    {
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.Horsepower = horsepower;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsepower;
    private int acceleration;
    private int suspension;
    private int durability;

    public int Durability
    {
        get { return this.durability; }
        protected set { this.durability = value; }
    }

    public int Suspension
    {
        get { return this.suspension; }
        protected set { this.suspension = value; }
    }

    public int Acceleration
    {
        get { return this.acceleration; }
        protected set { this.acceleration = value; }
    }

    public int Horsepower
    {
        get { return this.horsepower; }
        protected set { this.horsepower = value; }
    }

    public int YearOfProduction
    {
        get { return this.yearOfProduction; }
        protected set { this.yearOfProduction = value; }
    }

    public string Model
    {
        get { return this.model; }
        protected set { this.model = value; }
    }

    public string Brand
    {
        get { return this.brand; }
        protected set { this.brand = value; }
    }

    public virtual void Tune(int tuneIndex, string addOn)
    {
        this.Horsepower += tuneIndex;
        this.Suspension += tuneIndex / 2;
    }
}