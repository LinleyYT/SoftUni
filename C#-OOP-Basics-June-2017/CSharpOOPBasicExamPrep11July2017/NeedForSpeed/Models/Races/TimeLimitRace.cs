using System;
using System.Linq;
using System.Text;

public class TimeLimitRace : Race
{
    public TimeLimitRace(int length, string route, int prizePool, int goldTime)
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
        var timePerformance = CalculatePerformancePoints(this.Participants.FirstOrDefault());
        var badge = String.Empty;
        var sb = new StringBuilder();
        sb.AppendLine($"{this.Route} - {this.Length}");
        sb.AppendLine($"{this.Participants.FirstOrDefault().Brand} {this.Participants.FirstOrDefault().Model} - {timePerformance} s.");

        if (timePerformance <= this.GoldTime)
        {
            badge = "Gold";
            sb.AppendLine($"{badge} Time, ${this.PrizePool}.");

        }
        else if (timePerformance <= this.GoldTime + 15)
        {
            badge = "Silver";
            sb.AppendLine($"{badge} Time, ${(this.PrizePool * 50) / 100}.");
        }
        else if (timePerformance > this.GoldTime + 15)
        {
            badge = "Bronze";
            sb.AppendLine($"{badge} Time, ${(this.PrizePool * 30) / 100}.");
        }

        return sb.ToString().Trim();
    }

    public override int CalculatePerformancePoints(Car participant)
    {
        //raceLength  * ((participantHorsepower / 100) * participantAcceleration)
        return this.Length * ((this.Participants.Sum(x => x.Horsepower) / 100) *
                              this.Participants.Sum(x => x.Acceleration));
    }

    public override void AddParticipant(Car participant)
    {
        var participantCount = this.Participants.Count;
        if (participantCount < 1)
        {
            this.Participants.Add(participant);
        }
    }
}

