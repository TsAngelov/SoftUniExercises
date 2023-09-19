using System;
using System.Reflection.Metadata.Ecma335;

namespace _04._Car_to_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()), price = 0;
            string season = Console.ReadLine();
            string carClass = "", car = "";
            switch (season)
            {
                case "Summer":
                    car = "Cabrio";
                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        price = budget * 0.35;
                    }
                    else if (budget <= 500)
                    {
                        carClass = "Compact class";
                        price = budget * 0.45;
                    }
                    else
                    {
                        car = "Jeep";
                        carClass = "Luxury class";
                        price = budget * 0.9;
                    }
                    break;
                case "Winter":
                    car = "Jeep";
                    if (budget <= 100)
                    {
                        carClass = "Economy class";
                        price = budget * 0.65;
                    }
                    else if (budget <= 500)
                    {
                        carClass = "Compact class";
                        price = budget * 0.8;
                    }
                    else
                    {
                        carClass = "Luxury class";
                        price = budget * 0.9;
                    }
                    break;
            }
            Console.WriteLine(carClass);
            Console.WriteLine($"{car} - {price:f2}");
        }
    }
}
