using System;
using System.Collections.Generic;
using System.Linq;

public class ItemCommand : AbstractCommand
{
#pragma warning disable 649
    [Inject] private IList<IHero> heroes;
#pragma warning restore 649

    public ItemCommand(string[] data)
        : base(data)
    {
    }

    public override string Execute()
    {
        var itemName = this.Data[0];
        var heroName = this.Data[1];
        var strengthBonus = long.Parse(this.Data[2]);
        var agilityBonus = long.Parse(this.Data[3]);
        var intelligenceBonus = long.Parse(this.Data[4]);
        var hitPointsBonus = long.Parse(this.Data[5]);
        var damageBonus = long.Parse(this.Data[6]);

        IItem currentItem = new CommonItem(itemName, strengthBonus, agilityBonus,
            intelligenceBonus, hitPointsBonus, damageBonus);

        this.heroes.FirstOrDefault(h => h.Name.Equals(heroName, StringComparison.OrdinalIgnoreCase))
            .Inventory.AddCommonItem(currentItem);

        var commandResult = String.Format(Constants.ItemCreateMessage, currentItem.Name, heroName);

        return commandResult;
    }
}
