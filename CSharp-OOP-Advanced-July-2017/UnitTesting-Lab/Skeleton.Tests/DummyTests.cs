using System;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int AxeDurability = 10;
        private const int AxeAttackPoints = 10;
        private const int DummyHealth = 10;
        private const int DummyXP = 10;
        private Axe axe;
        private Dummy dummy;


        [SetUp]
        public void TestInit()
        {
            this.axe = new Axe(AxeAttackPoints, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXP);
        }


        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(DummyHealth, DummyXP);

            dummy.TakeAttack(5);

            Assert.AreEqual(5, dummy.Health, "Dummy doesn't loose health when attacked.");
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            Axe axe = new Axe(AxeAttackPoints, AxeDurability);
            Dummy dummy = new Dummy(DummyHealth, DummyXP);

            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message == "Dummy is dead.", "Dead dummy doesn't throw exception if attacked");
        }

        [Test]
        public void DeadDummyGivesXP()
        {
            Dummy dummy = new Dummy(DummyHealth, DummyXP);
            Axe axe = new Axe(AxeAttackPoints, AxeDurability);

            axe.Attack(dummy);

            Assert.AreEqual(10, dummy.GiveExperience(), "Dead dummy doesn't give XP");
        }

        [Test]
        public void AliveDummyDoesNotGiveXP()
        {
            Dummy dummy = new Dummy(DummyHealth, DummyXP);

            var ex = Assert.Catch<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.AreEqual("Target is not dead.", ex.Message, "Alive dummy gives XP");
        }
    }
}