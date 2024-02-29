namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private Car c;
        [Test]
        public void TestConstrucors()
        {
            c = new Car("s", "w", 2.2, 3);
            Assert.That(c.Make == "s" && c.Model == "w" && c.FuelConsumption == 2.2 && c.FuelCapacity == 3 && c.FuelAmount==0);
        }

        [Test]
        public void TestMake()
        {
            Assert.That( ()=>new Car(null, "w", 2.2, 3), Throws.ArgumentException );
        }

        [Test]
        public void TestModel()
        {
            Assert.That(() => new Car("s", null, 2.2, 3), Throws.ArgumentException);
        }

        [Test]
        public void TestFCon()
        {
            Assert.That(() => new Car("s", "w", -1, 3), Throws.ArgumentException);
        }

        [Test]
        public void TestFCap()
        {
            Assert.That(() => new Car("s", "w", 2.2, -1), Throws.ArgumentException);
        }

        [Test]
        public void TestRefuelEx()
        {
            Assert.That(() => c.Refuel(-1), Throws.ArgumentException);
        }

        [Test]
        public void TestRefuel()
        {
            c = new Car("s", "w", 2.2, 3);
            c.Refuel(2);
            Assert.That(c.FuelAmount == 2);
        }

        [Test]
        public void TestRefuelFull()
        {
            c = new Car("s", "w", 2.2, 3);
            c.Refuel(4);
            Assert.That(c.FuelAmount == 3);
        }

        [Test]
        public void TestDrive()
        {
            c = new Car("s", "w", 2, 3);
            c.Refuel(3);
            c.Drive(100);
            Assert.That(Math.Round(c.FuelAmount) == 1);
        }

        [Test]
        public void TestDriveEx()
        {
            Assert.That(() => c.Drive(100), Throws.InvalidOperationException);
        }
    }
}