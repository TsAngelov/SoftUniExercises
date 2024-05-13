using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }
        public void AddVehicle (Vehicle vehicle) 
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }
        public bool RemoveVehicle(string vin)
        {
            return Vehicles.Remove(Vehicles.FirstOrDefault(x => x.VIN == vin));
        }
        public int GetCount()
        {
            return Vehicles.Count();
        }
        public Vehicle GetLowestMileage()
        {
            return Vehicles.OrderBy(x => x.Mileage).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (var vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
