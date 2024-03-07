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
        private double fuelQuantity;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
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
