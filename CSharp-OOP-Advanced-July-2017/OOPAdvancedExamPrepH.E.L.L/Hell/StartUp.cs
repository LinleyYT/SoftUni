using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        IInputReader inputReader = new ConsoleInputReader();
        IOutputWriter outputWriter = new ConsoleOutputWriter();
        IHeroFactory factory = new HeroFactory();
        IInventory inventory = new HeroInventory();
        IList<IHero> heroes = new List<IHero>();
        IManager manager = new HeroManager(factory, inventory, heroes);
        Engine engine = new Engine(inputReader, outputWriter, manager);

        engine.Run();
    }
}