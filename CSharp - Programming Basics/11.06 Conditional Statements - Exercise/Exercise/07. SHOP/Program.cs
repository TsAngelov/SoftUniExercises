using System;

namespace _07._SHOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int graphicsCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int memory = int.Parse(Console.ReadLine());
            double graphicCardsPrice = graphicsCards * 250;
            double processorsPrice = graphicCardsPrice * 0.35 * processors;
            double memoryPrice = graphicCardsPrice * 0.10 * memory;
            double price = graphicCardsPrice + processorsPrice + memoryPrice;
            if (graphicsCards > processors)
            {
                price= price - price * 0.15;
            }
            if (price <= budget)
            {
                double remainingMoney = budget - price;
                Console.WriteLine($"You have {remainingMoney:F2} leva left!");
            }
            else
            {
                double moneyNeeded = price - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva more!");
            }
        }
    }
}
