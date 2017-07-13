using System;

public class Engine
{
    public Engine()
    {
        this.Manager = new CarManager();
    }

    private CarManager manager;

    public CarManager Manager { get => manager; set => manager = value; }

    public void Run()
    {
        string input = String.Empty;

        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            var commandArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ExecuteCommand(commandArgs);
        }
    }

    private void ExecuteCommand(string[] commandArgs)
    {
        var command = commandArgs[0];


        switch (command)
        {
            case "register":
                var id = int.Parse(commandArgs[1]);
                var type = commandArgs[2];
                var brand = commandArgs[3];
                var model = commandArgs[4];
                var yearOfProduction = int.Parse(commandArgs[5]);
                var horsepower = int.Parse(commandArgs[6]);
                var acceleration = int.Parse(commandArgs[7]);
                var suspension = int.Parse(commandArgs[8]);
                var durability = int.Parse(commandArgs[9]);
                Manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                break;
            case "check":
                var checkId = int.Parse(commandArgs[1]);
                Console.WriteLine(Manager.Check(checkId));
                break;
            case "open":
                var openId = int.Parse(commandArgs[1]);
                var openType = commandArgs[2];
                var openLength = int.Parse(commandArgs[3]);
                var openRoute = commandArgs[4];
                var openPrize = int.Parse(commandArgs[5]);
                Manager.Open(openId, openType, openLength, openRoute, openPrize);
                break;
            case "participate":
                var carId = int.Parse(commandArgs[1]);
                var raceId = int.Parse(commandArgs[2]);
                Manager.Participate(carId, raceId);
                break;
            case "start":
                var startRaceId = int.Parse(commandArgs[1]);
                Console.WriteLine(Manager.Start(startRaceId));
                break;
            case "park":
                var parkCarId = int.Parse(commandArgs[1]);
                Manager.Park(parkCarId);
                break;
            case "unpark":
                var unparkCarId = int.Parse(commandArgs[1]);
                Manager.Unpark(unparkCarId);
                break;
            case "tune":
                var tuneIndex = int.Parse(commandArgs[1]);
                var tuneAddOn = commandArgs[2];
                Manager.Tune(tuneIndex, tuneAddOn);
                break;
        }
    }
}

