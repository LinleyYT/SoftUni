using System;
using System.Linq;

public class CommandInterpreter
{
    public CommandInterpreter()
    {
        DraftManager = new DraftManager();
    }

    private DraftManager draftManager;

    public DraftManager DraftManager
    {
        get { return this.draftManager; }
        set { this.draftManager = value; }
    }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Shutdown")
        {
            var commandArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ExecuteCommand(commandArgs);
        }

        Console.WriteLine(DraftManager.ShutDown());
    }

    private void ExecuteCommand(string[] commandArgs)
    {
        var command = commandArgs[0];

        switch (command)
        {
            case "RegisterHarvester":
                var registerHarvesterArgs = commandArgs.Skip(1).ToList();
                Console.WriteLine(DraftManager.RegisterHarvester(registerHarvesterArgs));
                break;
            case "RegisterProvider":
                var registerProviderArgs = commandArgs.Skip(1).ToList();
                Console.WriteLine(DraftManager.RegisterProvider(registerProviderArgs));
                break;
            case "Day":
                Console.WriteLine(DraftManager.Day());
                break;
            case "Mode":
                var modeArgs = commandArgs.Skip(1).ToList();
                Console.WriteLine(DraftManager.Mode(modeArgs));
                break;
            case "Check":
                var checkArgs = commandArgs.Skip(1).ToList();
                Console.WriteLine(DraftManager.Check(checkArgs));
                break;
        }
    }
}

