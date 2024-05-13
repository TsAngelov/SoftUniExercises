using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : IDrivable
    {
        private const double FuelConsumptionIncrease = 0.9;
        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelConsumption = fuelConsumption + FuelConsumptionIncrease;
            FuelQuantity = fuelQuantity;
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            if (FuelConsumption * distance > FuelQuantity)
            {
                Console.WriteLine("Car needs refueling");
            }
            else
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Car travelled {distance} km");
            }
        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters;
        }
    }
}
