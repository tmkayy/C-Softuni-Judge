namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCase(new int[] {1, 2, 3, 4, 5 , 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17})]
        public void TestCapacity16(int[] data)
        {
            Assert.Throws<InvalidOperationException>(() => new Database(data));
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void TestAddEx(int[] data)
        {
            var d  = new Database(data);
            Assert.Throws<InvalidOperationException>(()=>d.Add(1), "Array's capacity must be exactly 16 integers!");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5})]
        public void TestAdd(int[] data)
        {
            var d = new Database(data);
            d.Add(6);
            Assert.That(d.Count, Is.EqualTo(6));
        }

        [TestCase(new int[] {})]
        public void TestRemoveEx(int[] data)
        {
            var d = new Database(data);
            Assert.Throws<InvalidOperationException>(() => d.Remove(), "The collection is empty!");
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        public void TestRemove(int[] data)
        {
            var d = new Database(data);
            d.Remove();
            Assert.That(d.Count == 4);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 })]
        public void TestFetch(int[] data)
        {
            var d = new Database(data);
            int[] d1 = d.Fetch();
            int[] d2 = { 1, 2, 3, 4, 5 };
            Assert.AreEqual(d2, d1);
        }
    }
}
