using System.Collections.Generic;

public interface IHero
{
    string Name { get; }

    ICollection<IItem> Items { get; }

    long Strength { get; }

    long Agility { get; }

    long Intelligence { get; }

    long HitPoints { get; }

    long Damage { get; }

    long PrimaryStats { get; }

    long SecondaryStats { get; }

    IInventory Inventory { get; }
}
