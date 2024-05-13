using System;

namespace _05._Godzilla_vs_Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double priceExtra = double.Parse(Console.ReadLine());
            double decor = budget * 0.1;
            double priceClothing;
            if (extras > 150)
            {
                priceClothing = (priceExtra - priceExtra * 0.1) * extras;
            }
            else
            {
                priceClothing = priceExtra * extras;
            }
            double price = priceClothing + decor;
            if (budget >= price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = price - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
        }
    }
}
