using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        [TestCase(10, 10, 10)]
        [TestCase(3, 10, 10)]
        [TestCase(2, 10, 10)]
        public void TestLoseHealth(int attack, int hp, int xp)
        {
            var dum = new Dummy(hp, xp);
            dum.TakeAttack(attack);
            Assert.That(dum.Health==hp-attack, "Dummy doesn't lose hp.");
        }

        [Test]
        [TestCase(10, 9, 10)]
        public void TestDeadAttack(int attack, int hp, int xp)
        {
            var dum = new Dummy(hp, xp);
            dum.TakeAttack(attack);
            Assert.Throws<InvalidOperationException>(()=>dum.TakeAttack(attack), "Dummy is dead.");
        }

        [Test]
        [TestCase(10, 10, 10)]
        public void TestCanGiveXP(int attack, int hp, int xp)
        {
            var dum = new Dummy(hp, xp);
            dum.TakeAttack(attack);
            Assert.That(10 == dum.GiveExperience());
        }

        [Test]
        [TestCase(9, 10, 10)]
        public void TestAliveXP(int attack, int hp, int xp)
        {
            var dum = new Dummy(hp, xp);
            dum.TakeAttack(attack);
            Assert.Throws<InvalidOperationException>(() => dum.GiveExperience(), "Target is not dead.");
        }
    }
}