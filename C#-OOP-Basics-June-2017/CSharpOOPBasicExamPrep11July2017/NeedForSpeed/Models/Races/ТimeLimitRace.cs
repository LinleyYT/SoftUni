public class ТimeLimitRace : Race
{
    public ТimeLimitRace(int length, string route, int prizePool, int goldTime)
    : base(length, route, prizePool)
    {
        this.GoldTime = goldTime;
    }

    private int goldTime;

    public int GoldTime
    {
        get { return this.goldTime; }
        set { this.goldTime = value; }
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

