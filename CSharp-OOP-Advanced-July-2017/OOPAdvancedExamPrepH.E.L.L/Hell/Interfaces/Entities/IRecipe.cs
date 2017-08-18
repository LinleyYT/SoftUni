using System.Collections.Generic;

public interface IRecipe
{
    IList<string> RequiredItems { get; }

    string RecipeItemName { get; }

    long StrengthBonus { get; }

    long AgilityBonus { get; }

    long IntelligenceBonus { get; }

    long HitPointsBonus { get; }

    long DamageBonus { get; }
}
