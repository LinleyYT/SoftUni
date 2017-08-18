using System;
using System.Collections.Generic;

public class HeroCommand : AbstractCommand
{
    [Inject]
    private IList<IHero> heroes;

    [Inject]
    private IHeroFactory heroFactory;

    public HeroCommand(string[] data)
        : base(data)
    {
    }

    public override string Execute()
    {
        var heroName = this.Data[0];
        var heroType = this.Data[1];

        var currentHero = this.heroFactory.CreateHero(heroType, heroName);
        this.heroes.Add(currentHero);

        return String.Format(Constants.HeroCreateMessage, currentHero.GetType().Name, currentHero.Name);
    }
}
