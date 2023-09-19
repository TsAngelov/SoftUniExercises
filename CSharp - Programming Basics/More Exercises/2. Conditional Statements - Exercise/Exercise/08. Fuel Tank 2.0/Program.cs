using System;
using System.ComponentModel.Design;

namespace _08._Fuel_Tank_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string ownership = Console.ReadLine();
            double price = 0;
            double fuelRate = 0;
            double fuelDiscount = 0;
            if (fuelType == "Gas")
            {
                fuelRate = 0.93;
                fuelDiscount = 0.85;
            }
            else if (fuelType == "Gasoline")
            {
                fuelRate = 2.22;
                fuelDiscount = 2.04;
            }
            else if (fuelType == "Diesel")
            {
                fuelRate = 2.33;
                fuelDiscount = 2.21;
            }
            if (ownership == "Yes")
            {
                price = fuelAmount * fuelDiscount;
            }
            else
            {
                price = fuelAmount * fuelRate;
            }
            if (fuelAmount >= 20 && fuelAmount <= 25)
            {
                price = price - price * 0.08;
            }
            else if (fuelAmount > 25)
            {
                price = price - price * 0.1;
            }
            Console.WriteLine($"{price:F2} lv.");
        }
    }
}