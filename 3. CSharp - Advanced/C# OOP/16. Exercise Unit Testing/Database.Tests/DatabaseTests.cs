namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.IO;

    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void SetUp()
        {
            database = new Database();
        }
        [Test]
        [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Ctor_WithInvalidCapacity_ShouldThrowError(int[] elements)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database = new Database(elements);
            });
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Constructor_Test_Elements(int[] elements)
        {
            database = new Database(elements);

            int[] databaseElements = database.Fetch();
            int[] expectedElements = elements;

            Assert.AreEqual(databaseElements, expectedElements);
        }

        [Test]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void Constructor_Test_DatabaseCount(int[] elements)
        {
            database = new Database(elements);

            int databaseCount = database.Count;
            int expectedCount = elements.Length;


            Assert.AreEqual(databaseCount, expectedCount);
        }

        [Test]
        public void Add_ShouldAddElementAtNextCell()
        {
            database = new Database(new int[] { 0, 1 });

            int expectedCount = database.Count + 1;

            database.Add(4);
            int databaseCountAfterAdd = database.Count;

            Assert.AreEqual(databaseCountAfterAdd, expectedCount);

        }

        [Test]
        public void Add_WhenCapacityIsFull_ShouldThrowError()
        {
            database = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });

            Assert.Throws<InvalidOperationException>(() => database.Add(1));

        }

        [Test]
        public void Remove_ShouldRemoveLastElement()
        {
            database = new Database(new int[] { 1, 2, 3, 4 });

            int databaseCountExpected = database.Count - 1;

            database.Remove();
            int databaseCountAfterRemove = database.Count;

            Assert.AreEqual(databaseCountAfterRemove, databaseCountExpected);
        }

        [Test]
        public void Remove_WhenEmpty_ShouldThrowError()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                database.Remove();
            });
        }
    }
}
