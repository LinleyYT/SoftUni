public class Ferrari : ICar
{
    public Ferrari(string driver)
    {
        this.Model = "488-Spider";
        this.Driver = driver;
    }

    public string Model { get; }
    public string Driver { get; }

    public string UseBreaks()
    {
        return "Brakes!";
    }

    public string PushGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{UseBreaks()}/{PushGasPedal()}/{this.Driver}";
    }
}