using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CasualRace : Race
{
    public CasualRace(int length, string route, int prizePool) 
        : base(length, route, prizePool)
    {
    }

    public override string StartRace()
    {
        foreach (var car in this.Participants)
        {
            var performancePooints = CalculatePerformancePoints(car);
            AddWinner(car, performancePooints);
        }

        var resultSb = new StringBuilder();
        resultSb.AppendLine($"{this.Route} - {this.Length}");
        var counter = 1;

        var winnerPercentages = new [] { 50, 30, 20 };
        var winnerPercentagesQueue = new Queue<int>(winnerPercentages);

        foreach (var kvp in this.Winners.OrderByDescending(x => x.Value).Take(3))
        {
            resultSb.AppendLine($"{counter}. {kvp.Key.Brand} {kvp.Key.Model} {kvp.Value}PP - ${this.PrizePool * winnerPercentagesQueue.Dequeue() / 100}");
            counter++;
        }

        return resultSb.ToString();
    }

    public override int CalculatePerformancePoints(Car participant)
    {
        return (participant.Horsepower / participant.Acceleration) + (participant.Suspension + participant.Durability);
    }
}

