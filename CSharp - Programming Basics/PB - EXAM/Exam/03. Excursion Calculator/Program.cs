using System;

namespace _03._Excursion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double price = 0, discount = 0;
            string season = Console.ReadLine();
            switch (season)
            {
                case "spring": 
                    if (people <= 5) price = 50; else price = 48;
                    break;

                case "summer": discount = 0.15;
                    if (people <= 5) price = 48.5; else price = 45;
                    break;

                case "autumn":
                    if (people <= 5) price = 60; else price = 49.5;
                    break;

                case "winter": discount = -0.08;
                    if (people <= 5) price = 86; else price = 85;
                    break;
            }
            double cost = price * people;
            cost -= cost * discount;
            Console.WriteLine($"{cost:f2} leva.");
        }
    }
}
