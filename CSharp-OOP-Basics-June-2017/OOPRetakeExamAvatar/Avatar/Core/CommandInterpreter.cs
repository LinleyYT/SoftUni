using System;
using System.Linq;

public class CommandInterpreter
{
    public CommandInterpreter()
    {
        this.NationsBuilder = new NationsBuilder();
    }

    private NationsBuilder nationsBuilder;

    public NationsBuilder NationsBuilder
    {
        get { return this.nationsBuilder; }
        set { this.nationsBuilder = value; }
    }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Quit")
        {
            var commandArgs = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            ExecuteCommand(commandArgs);
        }

        Console.WriteLine(NationsBuilder.GetWarsRecord());
    }

    private void ExecuteCommand(string[] commandArgs)
    {
        var command = commandArgs[0];

        switch (command)
        {
            case "Status":
                var requestedStatusType = commandArgs[1];
                Console.WriteLine(NationsBuilder.GetStatus(requestedStatusType));
                break;

            case "War":
                var nationDeclaringWar = commandArgs[1];
                NationsBuilder.IssueWar(nationDeclaringWar);
                break;

            case "Bender":
                var benderArgs = commandArgs.Skip(1).ToList();
                NationsBuilder.AssignBender(benderArgs);
                break;

            case "Monument":
                var monumentArgs = commandArgs.Skip(1).ToList();
                NationsBuilder.AssignMonument(monumentArgs);
                break;
        }
    }
}