using System;

public class HeroFactory : IHeroFactory
{
    public IHero CreateHero(string unitType, string name)
    {
        Type getType = Type.GetType(unitType);

        return (IHero) Activator.CreateInstance(getType, new object[] {name});
    }
}
