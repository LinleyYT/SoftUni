using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class HeroInventoryTests
{
    [Test]
    public void AddsCommonItem()
    {
        //Arrange
        var inventory = new HeroInventory();
        IItem item = new CommonItem("Knife", 0, 10, 0, 0, 30);
        Type getType = inventory.GetType();
        var field = getType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
            .FirstOrDefault(f => f.Name.Equals("commonItems", StringComparison.OrdinalIgnoreCase));

        var mockField = (Dictionary<string, IItem>) field.GetValue(false);

        //Assert
        inventory.AddCommonItem(item);

        //Assert
        Assert.AreEqual(1, mockField.Values.Count);
    }

    [Test]
    public void NullCommonItemThrowsNullException()
    {
        //Arrange
        var inventory = new HeroInventory();
        IItem item = null;

        //Assert
        Assert.Throws<NullReferenceException>(() => inventory.AddCommonItem(item));
    }

    [Test]
    public void NullRecipeThrowsNullException()
    {
        //Arrange
        var inventory = new HeroInventory();
        IRecipe recipe = null;

        //Assert
        Assert.Throws<NullReferenceException>(() => inventory.AddRecipeItem(recipe));
    }
}

