using System;
using System.ComponentModel.Design;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string location = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        location = "Camp";
                        price = budget * 0.3;
                        break;
                    case "winter":
                        location = "Hotel";
                        price = budget * 0.7;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        location = "Camp";
                        price = budget * 0.4;
                        break;
                    case "winter":
                        location = "Hotel";
                        price = budget * 0.8;
                        break;
                }
            }
            else
            {
                destination = "Europe";
                switch (season)
                {
                    case "summer":
                    case "winter":
                        location = "Hotel";
                        price = budget * 0.9;
                        break;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{location} - {price:f2}");
        }
    }
}
