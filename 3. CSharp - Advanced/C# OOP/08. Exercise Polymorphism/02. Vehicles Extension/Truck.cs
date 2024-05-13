using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelConsumptionModifier = 1.6;
        private const double TruckerFactor = 0.95;
        public Truck(double fuelConsumption, double fuelQuantity, double tankCapacity) 
            : base(fuelConsumption + FuelConsumptionModifier, fuelQuantity, tankCapacity)
        {
        }
        public override void Refuel(double fuelAmount)
        {
            if (fuelAmount + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }
            base.Refuel(fuelAmount * TruckerFactor);
        }
    }
}
