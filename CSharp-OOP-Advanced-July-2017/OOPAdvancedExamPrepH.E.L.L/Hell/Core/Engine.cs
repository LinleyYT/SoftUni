using System;
using System.Linq;

public class Engine
{
    private const string ExitCommand = "Quit";

    private IInputReader inputReader;
    private IOutputWriter outputWriter;
    private IManager heroManager;

    public Engine(IInputReader inputReader, IOutputWriter outputWriter, IManager heroManager)
    {
        this.inputReader = inputReader;
        this.outputWriter = outputWriter;
        this.heroManager = heroManager;
    }

    public void Run()
    {
        string input = String.Empty;

        while (true)
        {
            input = this.inputReader.ReadLine();
            string[] data = input.Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var commandName = data[0];
            var commandArgs = data.Skip(1).ToArray();
            var result = this.heroManager.InterpretCommand(commandArgs, commandName).Execute();
            this.outputWriter.WriteLine(result);

            if (input == ExitCommand)
            {
                Console.WriteLine();
                Environment.Exit(0);
            }
        } 
    }
}