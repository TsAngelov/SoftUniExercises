using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            if (fuelType == "Diesel" || fuelType == "Gasoline" || fuelType== "Gas")
            {
                if (liters >=25)
                {
                    Console.WriteLine($"You have enough {fuelType.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuelType.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
