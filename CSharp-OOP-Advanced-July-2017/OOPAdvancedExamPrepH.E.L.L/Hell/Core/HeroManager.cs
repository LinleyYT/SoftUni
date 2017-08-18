using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

public class HeroManager : IManager
{
    private const string CommandSuffix = "Command";

    private IList<IHero> heroes;
    private IHeroFactory heroFactory;
    private IInventory inventory;

    public HeroManager(IHeroFactory heroFactory, IInventory inventory, IList<IHero> heroes)
    {
        this.heroFactory = heroFactory;
        this.inventory = inventory;
        this.heroes = heroes;
    }

    public IExecutable InterpretCommand(string[] data, string commandName)
    {
        string commandCompleteName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName) + CommandSuffix;

        Type commandType = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t => t.Name.Equals(commandCompleteName, StringComparison.OrdinalIgnoreCase));

        object[] commandParams =
        {
            data
        };

        if (commandType == null)
        {
            throw new InvalidOperationException("Invalid command!");
        }

        IExecutable currentCommand = (IExecutable)Activator.CreateInstance(commandType, commandParams);

        currentCommand = this.InjectDependencies(currentCommand);

        return currentCommand;
    }

    private IExecutable InjectDependencies(IExecutable currentCommand)
    {
        FieldInfo[] fields = currentCommand.GetType()
            .GetFields(BindingFlags.Instance
                       | BindingFlags.NonPublic)
            .Where(f => f.GetCustomAttributes<InjectAttribute>() != null).ToArray();

        FieldInfo[] interpreterFields = this.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (FieldInfo field in fields)
        {
            field.SetValue(currentCommand, interpreterFields
                .FirstOrDefault(f => f.FieldType == field.FieldType)
                .GetValue(this));
        }

        return currentCommand;
    }
}