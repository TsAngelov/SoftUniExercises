using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public interface IDrivable
    {
        double FuelQuantity { get; set; }
        double FuelConsumption { get; set; }
        void Drive(double distance);
        void Refuel(double liters);
    }
}
