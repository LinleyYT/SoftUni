public class CircuitRace : Race
{
    public CircuitRace(int length, string route, int prizePool, int laps) 
        : base(length, route, prizePool)
    {
        this.Laps = laps;
    }

    private int laps;

    public int Laps
    {
        get { return this.laps; }
        set { this.laps = value; }
    }

    public override string StartRace()
    {
        throw new System.NotImplementedException();
    }

    public override int CalculatePerformancePoints(Car participant)
    {
        throw new System.NotImplementedException();
    }
}

