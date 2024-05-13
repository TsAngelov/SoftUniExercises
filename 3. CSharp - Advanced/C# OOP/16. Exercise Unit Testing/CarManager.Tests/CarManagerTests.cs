namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Reflection;

    [TestFixture]
    public class CarManagerTests
    {
        private const string make = "Mercedes";
        private const string model = "C220";
        private const double fuelconsumption = 6.8;
        private const double fuelCapacity = 66;
        private const double fuelToRefuel = 10;
        private const double distance = 132.35;
        private Car car;

        [SetUp]
        public void SetUp()
        {
            car = new Car(make, model, fuelconsumption, fuelCapacity);
        }
        [Test]
        public void Constructor_HappyPath_Test()
        {
            Assert.AreEqual(car.FuelAmount, 0);
        }

        [Test]
        [TestCase("", model, fuelconsumption, fuelCapacity)]
        [TestCase(make, "", fuelconsumption, fuelCapacity)]
        [TestCase(make, model, 0, fuelCapacity)]
        [TestCase(make, model, fuelconsumption, 0)]
        public void Constructor_InvalidArguments_Test(string make, string model, double fuelconsumption, double fuelCapacity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car(make, model, fuelconsumption, fuelCapacity);
            });
        }

        [Test]
        public void Refuel_ShouldRefuelCar()
        {
            double initialFuelAmount = car.FuelAmount;

            car.Refuel(fuelToRefuel);

            Assert.AreEqual(initialFuelAmount + fuelToRefuel, car.FuelAmount);
        }
        [Test]
        public void Refuel_WhenCapacityIsFull_ShouldSetToFuelCapacity()
        {
            car.Refuel(fuelCapacity + 1);
            Assert.AreEqual(car.FuelAmount, car.FuelCapacity);
        }
        [Test]
        public void Refuel_WhenFuelToRefuelIsBelowOne_ShouldThrowError()
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(0));
        }

        [Test]
        public void Drive_HappyPath_Test()
        {
            car.Refuel(fuelToRefuel);
            car.Drive(distance);

            double expectedLitersLeft = 1;

            Assert.AreEqual(expectedLitersLeft, Math.Round(car.FuelAmount, 3));
        }
        [Test]
        public void Drive_WhenFuelNeededIsMoreThanFuelAmount_ShouldThrowError()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(distance));
        }
    }
}