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
        private double fuelQuantity;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelConsumption = fuelConsumption + FuelConsumptionIncrease;
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
        }
        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > TankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    fuelQuantity = value;
                }
            }
        }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

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
