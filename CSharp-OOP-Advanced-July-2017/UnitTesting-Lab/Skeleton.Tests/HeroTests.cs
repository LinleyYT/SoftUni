using Moq;
using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        private const string Name = "Pesho";
        private Hero hero;
        private Mock<IWeapon> weapon;
        private Mock<ITarget> target;

        [SetUp]
        public void TestInit()
        {
            this.weapon = new Mock<IWeapon>();
            this.target = new Mock<ITarget>();
            this.target.Setup(w => w.Health).Returns(0);
            this.target.Setup(w => w.GiveExperience()).Returns(20);
            this.target.Setup(w => w.IsDead()).Returns(true);
            this.hero = new Hero(Name, weapon.Object);
        }

        [Test]
        public void HeroGainsXP()
        {
            this.hero.Attack(this.target.Object);

            Assert.AreEqual(20, this.hero.Experience);
        }
    }
}