using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()), transport = 0, price = 0;
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            switch (category)
            {
                case "VIP":
                    price = 499.99 * people;
                    break;
                case "Normal":
                    price = 249.99 * people;
                    break;
            }
            if (people > 0 && people <= 4)
                transport += budget * 0.75;
            else if (people <= 9)
                transport += budget * 0.6;
            else if (people <= 24)
                transport += budget * 0.5;
            else if (people <= 49)
                transport += budget * 0.4;
            else
                transport += budget * 0.25;

            price += transport;
            if (budget >= price)
                Console.WriteLine($"Yes! You have {budget-price:f2} leva left.");
            else
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
        }
    }
}
