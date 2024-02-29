namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class ArenaTests
    {
        private Warrior w1;
        private Warrior w2;
        private Arena a;
        [SetUp]
        public void setmeupnigga()
        {
            w1 = new Warrior("a", 25, 10000);
            w2 = new Warrior("v", 25, 10000);
        }

        [Test]
        public void UselessTestByHris()
        {
            Arena arena = new Arena();
            List<Warrior> list = new List<Warrior>();
            CollectionAssert.AreEqual(list, arena.Warriors);
        }

        [Test]
        public void Enroll()
        {
            a = new Arena();
            a.Enroll(w1);
            a.Enroll(w2);
            Assert.AreEqual(a.Warriors.Count, a.Count);
            Assert.AreEqual(2, a.Count);
        }

        [Test]
        public void EnrollEx()
        {
            a = new Arena();
            a.Enroll(w1);
            Assert.That(() => a.Enroll(w1), Throws.InvalidOperationException);
        }

        [Test]
        [TestCase("b", "a")]
        [TestCase("a", "b")]
        public void FightEx(string attackerName, string defenderName)
        {
            a = new Arena();
            a.Enroll(w1);
            a.Enroll(w2);
            Assert.That(() => a.Fight(attackerName, defenderName), Throws.InvalidOperationException);
        }

        [Test]
        public void Fight()
        {
            a = new Arena();
            a.Enroll(w1);
            a.Enroll(w2);
            int hp1 = w1.HP;
            int hp2 = w2.HP;
            a.Fight("a", "v");
            Assert.That(w1.HP == hp1 - w2.Damage && w2.HP == hp2 - w1.Damage);
        }
    }
}
