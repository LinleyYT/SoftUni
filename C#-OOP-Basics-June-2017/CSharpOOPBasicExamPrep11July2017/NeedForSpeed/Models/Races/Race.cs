using System.Collections.Generic;

public abstract class Race
{
    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new List<Car>();
        this.winners = new Dictionary<Car, int>();
    }

    public const string NotEnoughParticipants = "Cannot start the race with zero participants.";

    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    private Dictionary<Car, int> winners;

    protected Dictionary<Car, int> Winners
    {
        get { return this.winners; }
        set { this.winners = value; }
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        private set { this.participants = value; }
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

    public void AddParticipant(Car participant)
    {
        this.Participants.Add(participant);
    }

    public void AddWinner(Car winnerCar, int points)
    {
        if (!this.winners.ContainsKey(winnerCar))
        {
            this.winners.Add(winnerCar, points);
        }
        else
        {
            this.winners[winnerCar] = points;
        }
    }

    public abstract string StartRace();
    public abstract int CalculatePerformancePoints(Car participant);
}


