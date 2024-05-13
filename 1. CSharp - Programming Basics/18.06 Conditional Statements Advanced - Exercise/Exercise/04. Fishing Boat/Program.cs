using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else
                        price = price - price * 0.25;
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 0.05;
                    }
                    break;
                case "Summer":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else
                        price = price - price * 0.25;
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 0.05;
                    }
                    break;
                case "Autumn":
                    price = 4200;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else
                        price = price - price * 0.25;
                    break;
                case "Winter":
                    price = 2600;
                    if (fishermen <= 6)
                    {
                        price = price - price * 0.1;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = price - price * 0.15;
                    }
                    else
                        price = price - price * 0.25;
                    if (fishermen % 2 == 0)
                    {
                        price = price - price * 0.05;
                    }
                    break;
            }
            if (price <= budget)
            {
                price = budget - price;
                Console.WriteLine($"Yes! You have {price:f2} leva left.");
            }
            else
            {
                price = price - budget;
                Console.WriteLine($"Not enough money! You need {price:f2} leva.");
            }
        }
    }
}
