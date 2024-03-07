using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : IDrivable
    {
        private const double FuelConsumptionIncrease = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption)
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
                Console.WriteLine("Truck needs refueling");
            }
            else
            {
                FuelQuantity -= FuelConsumption * distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
        }

        public void Refuel(double liters)
        {
            FuelQuantity += liters * 0.95;
        }
    }
}
