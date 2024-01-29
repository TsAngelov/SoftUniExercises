using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;

public class Car
{
	private string make;
	private string model;
    private int year;
    private double fuelQuantity;
    private double fuelConsumption;

    public Car() 
    {
        Make = "VW";
        Model = "Golf";
        Year = 2025;
        FuelQuantity = 200;
        FuelConsumption = 10;
    }
    public Car(string make, string model, int year) : this()
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
    {
        this.FuelConsumption = fuelConsumption;
        this.FuelQuantity = fuelQuantity;
    }

    public string Make
	{
		get { return this.make; }
		set { this.make = value; }
	}
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public int Year
    {
        get { return this.year; }
        set { this.year = value; }
    }
    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }
    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }

    public void Drive(double distance)
    {
        if (this.FuelQuantity - (distance * this.FuelConsumption) > 0)
        {
            this.FuelQuantity -= (distance * this.FuelConsumption);
        }
        else
        {
            Console.WriteLine("Not enough fuel to perfom this trip!");
        }
    }
    public string WhoAmI()
    {
        StringBuilder sb = new();

        sb.AppendLine($"Make {this.Make}");
        sb.AppendLine($"Model {this.Model}");
        sb.AppendLine($"Year{this.Year}");
        sb.AppendLine($"Fuel {this.FuelQuantity:f2}");

        //return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:f2}";
        return sb.ToString().TrimEnd();
    }
}


