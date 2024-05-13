using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double FuelConsumptionModifier = 0.9;
        public Car(double fuelConsumption, double fuelQuantity, double tankCapacity) 
            : base(fuelConsumption + FuelConsumptionModifier, fuelQuantity, tankCapacity)
        {
        }
    }
}
