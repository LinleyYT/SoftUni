using System;
using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private const int AxeDurability = 10;
    private const int AxeAttackPoints = 10;
    [Test]
    public void AxeLosesDurabilityAfterAttach()
    {
        Axe axe = new Axe(AxeAttackPoints, AxeDurability);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        Assert.AreEqual(9, axe.DurabilityPoints, "Axe Durability doesn't change after attack");
    }

    [Test]
    public void BrokenAxeCantAttack()
    {
        Axe axe = new Axe(1, 1);
        Dummy dummy = new Dummy(10, 10);

        axe.Attack(dummy);

        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.That(ex.Message == "Axe is broken.");
    }
}

