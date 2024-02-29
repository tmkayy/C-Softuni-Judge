using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        [TestCase(10, 5, 10, 10)]
        [TestCase(3, 4, 10, 10)]
        [TestCase(2, 1, 10, 10)]
        public void TestLoseDurability(int attack, int durability, int hp, int xp)
        {
            var axe = new Axe(attack, durability);
            var dum = new Dummy(hp, xp);
            axe.Attack(dum);
            Assert.That(axe.DurabilityPoints == durability - 1, "Axe Durability doesn't change after attack.");
        }

        [Test]
        [TestCase(3, 0, 10, 10)]
        public void TestBroken(int attack, int durability, int hp, int xp)
        {
            var axe = new Axe(attack, durability);
            var dum = new Dummy(hp, xp);
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dum), "Axe is broken.");
        }
    }
}