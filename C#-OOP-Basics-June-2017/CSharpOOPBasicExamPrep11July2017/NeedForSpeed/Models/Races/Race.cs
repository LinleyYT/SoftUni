using System.Collections.Generic;

public abstract class Race
{
    public Race(int length, string route, int prizePool, List<Car> participants)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = participants;
    }

    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    public List<Car> Participants
    {
        get { return this.participants; }
        protected set { this.participants = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        protected set { this.prizePool = value; }
    }

    public string Route
    {
        get { return this.route; }
        protected set { this.route = value; }
    }

    public int Length
    {
        get { return this.length; }
        protected set { this.length = value; }
    }
}


