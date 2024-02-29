namespace FightingArena.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior w;
        private Warrior w2;
        [Test]
        public void TestConstructor()
        {
            w = new Warrior("a", 25, 50);
            Assert.That(w.Name == "a" && w.Damage == 25 && w.HP == 50);
        }

        [Test]
        [TestCase(" ")]
        [TestCase("")]
        [TestCase(null)]
        public void TestNameEx(string name)
        {
            Assert.That(() => new Warrior(name, 25, 50), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-15)]
        public void TestDmgEx(int dmg)
        {
            Assert.That(() => new Warrior("a", dmg, 50), Throws.ArgumentException);
        }
        [Test]
        public void TestHPEx()
        {
            Assert.That(() => new Warrior("a", 25, -1), Throws.ArgumentException);
        }

        [Test]
        public void TestAttackHPEx()
        {
            w = new Warrior("a", 25, 30);
            w2 = new Warrior("a", 25, 50);
            Assert.That(() => w.Attack(w2), Throws.InvalidOperationException);
        }

        [Test]
        public void TestAttackHP2Ex()
        {
            w = new Warrior("a", 25, 50);
            w2 = new Warrior("a", 25, 30);
            Assert.That(() => w.Attack(w2), Throws.InvalidOperationException);
        }

        [Test]
        public void TestAttackHP3Ex()
        {
            w = new Warrior("a", 25, 24);
            w2 = new Warrior("a", 25, 50);
            Assert.That(() => w.Attack(w2), Throws.InvalidOperationException);
        }

        [Test]
        public void TestAttack()
        {
            w = new Warrior("a", 25, 50);
            w2 = new Warrior("a", 25, 50);
            w.Attack(w2);
            Assert.That(w.HP==25 && w2.HP==25);
        }

        [Test]
        public void TestDeath()
        {
            w = new Warrior("a", 50, 49);
            w2 = new Warrior("a", 25, 48);
            w.Attack(w2);
            Assert.That(w2.HP==0);
        }
    }
}