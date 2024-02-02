using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TravelledDistance { get; set; }
    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        TravelledDistance = 0;
    }
    public void Drive(double km)
    {
        if (FuelAmount - (FuelConsumptionPerKilometer * km) >= 0)
        {
            TravelledDistance += km;
            FuelAmount -= FuelConsumptionPerKilometer * km;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {TravelledDistance}";
    }

}
