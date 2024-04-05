namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private const string ValidUsernameOne = "Patrona";
        private const long ValidIdOne = 100001;
        private const string ValidUsernameTwo = "Petar";
        private const long ValidIdTwo = 100002;
        private Database database;
        private const int MaxPeople = 16;

        [SetUp]
        public void SetUp()
        {
            Person patrona = new Person(ValidIdOne, ValidUsernameOne);
            Person petar = new Person(ValidIdTwo, ValidUsernameTwo);
            Person[] people = new Person[] { patrona, petar };

            database = new Database(people);
        }

        [Test]
        public void Constructor_Empty_CreatesNewInstance()
        {
            Database db = new Database();
            Assert.That(db, Is.Not.Null);
            Assert.AreEqual(db.Count, 0);
        }

        [Test]
        public void Constructor_WithValidParameter_CreatesNewInstance()
        {
            Assert.That(database, Is.Not.Null);
            Assert.AreEqual(database.Count, 2);
        }

        [Test]
        public void Constructor_WithTooManyPeople_ShouldThrowException()
        {
            Person[] tooManyPeople = new Person[MaxPeople + 1];

            for (int i = 0; i < tooManyPeople.Length; i++)
            {
                tooManyPeople[i] = new Person(i, $"test{i}");
            }

            Assert.Throws<ArgumentException>(() => new Database(tooManyPeople));
        }
        [Test]
        public void Add_AddsNewPerson()
        {
            Person stokata = new Person(ValidIdTwo + 1, "Stokata");
            database.Add(stokata);

            Assert.AreEqual(database.Count, 3);
        }

        [Test]
        public void Add_WhenFull_ShouldThrowError()
        {
            Person[] tooManyPeople = new Person[MaxPeople];

            for (int i = 0; i < tooManyPeople.Length; i++)
            {
                tooManyPeople[i] = new Person(i, $"test{i}");
            }

            database = new Database(tooManyPeople);

            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(10000, "Mitko")));
        }

        [Test]
        public void Add_UserWithSameUsername_ShouldThrowError()
        {
            Person sameNamePerson = new Person(ValidIdTwo + 1, ValidUsernameTwo);
            Assert.Throws<InvalidOperationException>(() => database.Add(sameNamePerson));
        }

        [Test]
        public void Add_UserWithSameId_ShouldThrowError()
        {
            Person sameIdPerson = new Person(ValidIdTwo, "Newcomer");
            Assert.Throws<InvalidOperationException>(() => database.Add(sameIdPerson));
        }
        [Test]
        public void Remove_ShouldRemoveLastPerson()
        {
            int expectedCount = database.Count - 1;

            database.Remove();

            int afterCount = database.Count;

            Assert.AreEqual(expectedCount, afterCount);
        }
        [Test]
        public void Remove_WhenEmpty_ShouldThrowError()
        {
            database = new Database();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void FindByUsername_ShouldFindPerson()
        {
            Person personFound = database.FindByUsername(ValidUsernameOne);

            Assert.That(personFound.UserName == ValidUsernameOne);
        }
        [Test]
        public void FindByUsername_WhenNullParameter_ShouldThrowErrow()
        {
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));
        }
        [Test]
        public void FindByUsername_WhenNotFoundUsername_ShouldThrowError()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Non-existent"));
        }
        [Test]
        public void FindByUsername_CaseSensitive_ShouldThrowError()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername(ValidUsernameOne.ToUpper()));
        }

        [Test]
        public void FindById_ShouldFindPerson()
        {
            Person personFound = database.FindById(ValidIdOne);

            Assert.That(personFound.Id == ValidIdOne);
        }
        [Test]
        public void FindById_WhenIdIsNegative_ShouldThrowError()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));
        }
        [Test]
        public void FindById_WhenIdNotFound_ShouldThrowError()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindById(000000));
        }

    }
}