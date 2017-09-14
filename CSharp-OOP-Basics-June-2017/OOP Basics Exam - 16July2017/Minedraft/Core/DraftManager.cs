using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    public DraftManager()
    {
        this.AllHarvesters = new List<Harvester>();
        this.AllProviders = new List<Provider>();
        this.TotalStoredEnergy = 0;
        this.TotalMinedOre = 0;
        this.ModeState = "Full Mode";
    }

    private string modeState;

    public string ModeState
    {
        get { return this.modeState; }
        private set { this.modeState = value; }
    }

    private double totalMinedOre;

    public double TotalMinedOre
    {
        get { return this.totalMinedOre; }
        private set { this.totalMinedOre = value; }
    }

    private double totalStoredEnergy;

    public double TotalStoredEnergy
    {
        get { return this.totalStoredEnergy; }
        private set { this.totalStoredEnergy = value; }
    }

    private List<Harvester> allHarvesters;

    public List<Harvester> AllHarvesters
    {
        get { return this.allHarvesters; }
        private set { this.allHarvesters = value; }
    }

    private List<Provider> allProviders;

    public List<Provider> AllProviders
    {
        get { return this.allProviders; }
        private set { this.allProviders = value; }
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            var harvesterFactory = new HarvesterFactory();
            var currentHarvester = harvesterFactory.CreateHarvester(arguments);
            AddHarvester(currentHarvester);

            return $"Successfully registered {arguments[0]} Harvester - {currentHarvester.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            var providerFactory = new ProviderFactory();
            var currentProvider = providerFactory.CreateProvider(arguments);
            AddProvider(currentProvider);

            return $"Successfully registered {arguments[0]} Provider - {currentProvider.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    public string Day()
    {
        var sb = new StringBuilder();

        var dailyEnergyOutput = this.AllProviders.Sum(x => x.EnergyOutput);

        var requiredEnergyForMining = 0.0;
        double minedOreDay = 0;

        switch (this.ModeState)
        {
            case "Full Mode":
                AddDayEnergyToTotal();
                requiredEnergyForMining = this.AllHarvesters.Sum(x => x.EnergyRequirement);
                if (requiredEnergyForMining <= this.TotalStoredEnergy)
                {
                    minedOreDay = this.AllHarvesters.Sum(x => x.OreOutput);
                    IncreaseOreAfterProduction(minedOreDay);
                    DecreaseEnergyAfterProduction(requiredEnergyForMining);
                }
                break;

            case "Half Mode":
                AddDayEnergyToTotal();
                requiredEnergyForMining = (this.AllHarvesters.Sum(x => x.EnergyRequirement)) * 0.6;
                if (requiredEnergyForMining <= this.TotalStoredEnergy)
                {
                    minedOreDay = (this.AllHarvesters.Sum(x => x.OreOutput)) * 0.5;
                    IncreaseOreAfterProduction(minedOreDay);
                    DecreaseEnergyAfterProduction(requiredEnergyForMining);
                }
                break;

            case "Energy Mode":
                AddDayEnergyToTotal();
                break;
        }

        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {dailyEnergyOutput}");
        sb.AppendLine($"Plumbus Ore Mined: {minedOreDay}");

        return sb.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];

        ModeChange($"{mode} Mode");

        return $"Successfully changed working mode to {mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        var checkId = arguments[0];

        if (this.AllHarvesters.Any(x => x.Id == checkId))
        {
            return AllHarvesters.FirstOrDefault(x => x.Id == checkId).ToString();
        }
        else if (this.AllProviders.Any(x => x.Id == checkId))
        {
            return AllProviders.FirstOrDefault(x => x.Id == checkId).ToString();
        }
        else
        {
            return $"No element found with id - {checkId}";
        }
    }

    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine("System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.TotalStoredEnergy}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.TotalMinedOre}");

        return sb.ToString().Trim();
    }

    private void AddHarvester(Harvester currentHarvester)
    {
        this.AllHarvesters.Add(currentHarvester);
    }

    private void AddProvider(Provider currentProvider)
    {
        this.AllProviders.Add(currentProvider);
    }

    private void AddDayEnergyToTotal()
    {
        this.TotalStoredEnergy += this.AllProviders.Sum(x => x.EnergyOutput);
    }

    private void DecreaseEnergyAfterProduction(double requiredEnergyForMining)
    {
        this.TotalStoredEnergy -= requiredEnergyForMining;
    }

    private void IncreaseOreAfterProduction(double minedOreDay)
    {
        this.TotalMinedOre += minedOreDay;
    }

    private void ModeChange(string mode)
    {
        this.ModeState = mode;
    }
}