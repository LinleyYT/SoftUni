using System;

public class HeroFactory : IHeroFactory
{
    public IHero CreateHero(string unitType, string name)
    {
        IInventory inventory = new HeroInventory();
        Type getType = Type.GetType(unitType);

        return (IHero) Activator.CreateInstance(getType, new object[] {name, inventory});
    }
}
