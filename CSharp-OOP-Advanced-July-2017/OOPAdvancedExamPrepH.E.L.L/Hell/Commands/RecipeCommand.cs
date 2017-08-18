using System;
using System.Collections.Generic;
using System.Linq;

public class RecipeCommand : AbstractCommand
{
#pragma warning disable 649
    [Inject] private IList<IHero> heroes;
#pragma warning restore 649

    public RecipeCommand(string[] data) : base(data)
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
        var requiredItemsStrings = this.Data.Skip(7);

        IRecipe recipeItem = new RecipeItem(itemName, strengthBonus, agilityBonus,
            intelligenceBonus, hitPointsBonus, damageBonus, requiredItemsStrings);

        this.heroes.FirstOrDefault(h => h.Name.Equals(heroName, StringComparison.OrdinalIgnoreCase))
            .Inventory.AddRecipeItem(recipeItem);

        var commandResult = String.Format(Constants.RecipeCreatedMessage, recipeItem.RecipeItemName, heroName);

        return commandResult;
    }
}
