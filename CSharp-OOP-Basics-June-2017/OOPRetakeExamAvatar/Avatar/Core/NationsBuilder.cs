using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public class NationsBuilder
{
    public NationsBuilder()
    {
        this.Nation = new Nation();
        this.AllMonuments = new List<Monument>();
        this.DeclaratorsOfWarQueue = new Queue<string>();
    }

    private Nation nation;
    private List<Monument> allMonuments;
    private Queue<string> declaratorsOfWarQueue;

    public Queue<string> DeclaratorsOfWarQueue
    {
        get { return this.declaratorsOfWarQueue; }
        set { this.declaratorsOfWarQueue = value; }
    }

    public List<Monument> AllMonuments
    {
        get { return this.allMonuments; }
        set { this.allMonuments = value; }
    }
    
    public Nation Nation
    {
        get { return this.nation; }
        private set { this.nation = value; }
    }

    public void AssignBender(List<string> benderArgs)
    {
        var benderFactory = new BenderFactory();
        var bender = benderFactory.CreateBender(benderArgs);
        Nation.AddBender(bender);
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var monumentFactory = new MonumentFactory();
        var monument = monumentFactory.CreateMonument(monumentArgs);
        AddMonument(monument);
    }
    public string GetStatus(string nationsType)
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{nationsType} Nation");
      

        if (Nation.AllBenders.Where(x => x.GetType().Name == $"{nationsType}Bender").ToArray().Length == 0)
        {
            sb.AppendLine("Benders: None");
        }
        else
        {
            sb.AppendLine("Benders:");
            foreach (var bender in Nation.AllBenders.Where(x => x.GetType().Name == $"{nationsType}Bender"))
            {
                sb.AppendLine($"###{bender}");
            }
        }
        if (AllMonuments.Where(x => x.GetType().Name == $"{nationsType}Monument").ToArray().Length == 0)
        {
            sb.AppendLine("Monuments: None");
        }
        else
        {
            sb.AppendLine("Monuments:");
            foreach (var monument in AllMonuments.Where(x => x.GetType().Name == $"{nationsType}Monument"))
            {
                sb.AppendLine($"###{monument}");
            }
        }

        return sb.ToString().Trim();
    }
    public void IssueWar(string nationsType)
    {
        DeclaratorsOfWarQueue.Enqueue(nationsType);

        var winnerBender = DetermineWinner();
        var type = winnerBender.Substring(0, winnerBender.Length - 6);

        Nation.RemoveLosers(type);
        RemoveLoserMonuments(type);
    }

    public string GetWarsRecord()
    {
        var sb = new StringBuilder();
        var counter = 1;
        var queueCount = this.DeclaratorsOfWarQueue.Count;
        for (int i = 0; i < queueCount; i++)
        {
            sb.AppendLine($"War {counter} issued by {this.DeclaratorsOfWarQueue.Dequeue()}");
            counter++;
        }

        return sb.ToString().Trim();
    }

    public void AddMonument(Monument monument)
    {
        this.allMonuments.Add(monument);
    }

    private string DetermineWinner()
    {
        var winnerByType = new Dictionary<string, double>();

        winnerByType.Add("AirBender", this.Nation.AllBenders.Where(x => x.GetType().Name == "AirBender")
            .Sum(y => y.CalculatePower()));
        winnerByType.Add("EarthBender", this.Nation.AllBenders.Where(x => x.GetType().Name == "EarthBender")
            .Sum(y => y.CalculatePower()));
        winnerByType.Add("FireBender", this.Nation.AllBenders.Where(x => x.GetType().Name == "FireBender")
            .Sum(y => y.CalculatePower()));
        winnerByType.Add("WaterBender", this.Nation.AllBenders.Where(x => x.GetType().Name == "WaterBender")
            .Sum(y => y.CalculatePower()));

        winnerByType["AirBender"] += (winnerByType["AirBender"] / 100) * this.AllMonuments
                                         .Where(x => x.GetType().Name == "AirMonument")
                                         .Sum(y => y.CalculateMonumentPoints());
        winnerByType["EarthBender"] += (winnerByType["EarthBender"] / 100) * this.AllMonuments
                                         .Where(x => x.GetType().Name == "EarthMonument")
                                         .Sum(y => y.CalculateMonumentPoints());
        winnerByType["FireBender"] += (winnerByType["FireBender"] / 100) * this.AllMonuments
                                           .Where(x => x.GetType().Name == "FireMonument")
                                           .Sum(y => y.CalculateMonumentPoints());
        winnerByType["WaterBender"] += (winnerByType["WaterBender"] / 100) * this.AllMonuments
                                          .Where(x => x.GetType().Name == "WaterMonument")
                                          .Sum(y => y.CalculateMonumentPoints());
 
        var max = winnerByType.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        return max;
    }

    private void RemoveLoserMonuments(string type)
    {
        this.AllMonuments = this.AllMonuments.Where(x => x.GetType().Name.Contains(type)).ToList();
    }
}

