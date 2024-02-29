namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database d;

        [SetUp]
        public void Setup()
        {
            Person[] people = new Person[14];
            for (int i = 0; i < people.Length; i++)
                people[i] = new Person(i, ((char)('A' + i)).ToString());
            d = new Database(people);
        }

        [Test]
        public void AddExName()
        {
            Assert.Throws<InvalidOperationException>(() => d.Add(new Person(1233, "A")), "There is already user with this username!");
        }

        [Test]
        public void AddExId()
        {
            Assert.That(() => d.Add(new Person(1, "John")), Throws.InvalidOperationException);
        }

        [Test]
        public void TestRemove()
        {
            var d1 = d;
            d1.Remove();
            Assert.That(d1.Count, Is.EqualTo(13));
        }

        [Test]
        public void TestFindNullEx()
        {
            Assert.That(()=>d.FindByUsername(null), Throws.ArgumentNullException);
        }

        [Test]
        public void TestNoName()
        {
            Assert.That(() => d.FindByUsername("AJJSUAIAJSOAJSUWS"), Throws.InvalidOperationException);
        }

        [Test]
        public void FindByUsername_ReturnsTheCorrectPerson()
        {
            Person personToFind = d.FindByUsername("A");
            Assert.AreEqual(personToFind.UserName, "A");
        }

        [Test]
        public void FindById_ReturnsTheCorrectPerson()
        {
            Person personToFind = d.FindById(4);
            Assert.AreEqual(personToFind.Id, 4);
        }

        [Test]
        public void TestNegID()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => d.FindById(-1));
        }

        [Test]
        public void TestNoID()
        {
            Assert.Throws<InvalidOperationException>(() => d.FindById(1212121212));
        }

        [Test]
        public void Constructor_CannotTakeMoreThan16People()
        {
            Person[] people = new Person[17];
            for (int i = 0; i < people.Length; i++)
                people[i] = new Person(i, ((char)('A' + i)).ToString());
            Assert.Throws<ArgumentException>(() => d = new Database(people));
        }

        [Test]
        public void Add_IncreasesTheCollectionCount()
        {
            d.Add(new Person(14, "Joe"));
            Assert.AreEqual(d.Count, 15);
        }

        [Test]
        public void Add_CannotAddPersonWithExistingName()
        {
            Assert.That(() => d.Add(new Person(100, "A")), Throws.InvalidOperationException);
        }

        [Test]
        public void Add_CannotAddPersonWithExistingID()
        {
            Assert.That(() => d.Add(new Person(1, "John")), Throws.InvalidOperationException);
        }

        [Test]
        public void Add_CannotExceedMaximumArrayCount()
        {
            d.Add(new Person(14, "Fourteen"));
            d.Add(new Person(15, "Sixteen"));
            Assert.That(() => d.Add(new Person(16, "Error")), Throws.InvalidOperationException);
        }

        [Test]
        public void Add_AddsPersonToTheCollection()
        {
            Person person = new Person(14, "Jimmy");
            d.Add(person);
            Person expected = d.FindById(14);
            Assert.AreEqual(person, expected);
        }

        [Test]
        public void Remove_RemovesLastPersonFromTheCollection()
        {
            Person person = new Person(14, "Lilly");
            d.Add(person);
            d.Remove();
            Assert.That(() =>d.FindByUsername("Lilly"), Throws.InvalidOperationException);
        }

        [Test]
        public void Remove_CantFunctionOnEmptyCollection()
        {
            Database database = new Database();
            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }

        [Test]
        public void Remove_DecreasesTheCollectionCount()
        {
            int expectedCount = d.Count - 1;
            d.Remove();
            Assert.AreEqual(d.Count, expectedCount);
        }

    }
}