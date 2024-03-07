using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle : IDrivable, IRefuable
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        protected Vehicle(double fuelConsumption, double fuelQuantity, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Tank capacity must be positive number");
                }
                tankCapacity = value;
            }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Consumption must be positive number");
                }
                fuelConsumption = value;
            }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be positive number");
                }

                if (value <= TankCapacity)
                {
                    fuelQuantity = value;
                }
                else
                {
                    fuelQuantity = 0;
                }
            }
        }

        public virtual void Drive(double distance)
        {
            double totalConsumption = distance * FuelConsumption;
            if (totalConsumption > FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                FuelQuantity -= totalConsumption;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            double totalFuelAfterRefueling = fuelAmount + FuelQuantity;
            if (totalFuelAfterRefueling > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }

            FuelQuantity += fuelAmount;
        }

    }
}
