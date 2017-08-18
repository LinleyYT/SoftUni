using System.Collections.Generic;
using System.Linq;

public class RecipeItem : IRecipe
{
    public RecipeItem(string name, long strengthBonus, long agilityBonus, long intelligenceBonus,
        long hitPointsBonus, long damageBonus, IEnumerable<string> requiredItems)
    {
        this.RecipeItemName = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
        this.RequiredItems = requiredItems.ToList();
    }

    public string RecipeItemName { get; }

    public long StrengthBonus { get; }

    public long AgilityBonus { get; }

    public long IntelligenceBonus { get; }

    public long HitPointsBonus { get; }

    public long DamageBonus { get; }

    public IList<string> RequiredItems { get; }
}
