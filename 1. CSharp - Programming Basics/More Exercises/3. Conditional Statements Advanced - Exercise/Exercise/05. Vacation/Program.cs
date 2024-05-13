using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()), price = 0;
            string season = Console.ReadLine(), location = "", country = "";
            if (budget <= 1000)
            {
                location = "Camp";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.65;
                        country = "Alaska";
                        break;
                    case "Winter":
                        price = budget * 0.45;
                        country = "Morocco";
                        break;
                }
            }
            else if (budget <=3000)
            {
                location = "Hut";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.8;
                        country = "Alaska";
                        break;
                    case "Winter":
                        price = budget * 0.6;
                        country = "Morocco";
                        break;
                }
            }
            else
            {
                location = "Hotel";
                switch (season)
                {
                    case "Summer":
                        price = budget * 0.9;
                        country = "Alaska";
                        break;
                    case "Winter":
                        price = budget * 0.9;
                        country = "Morocco";
                        break;
                }
            }
            Console.WriteLine($"{country} - {location} - {price:f2}");
        }
    }
}
