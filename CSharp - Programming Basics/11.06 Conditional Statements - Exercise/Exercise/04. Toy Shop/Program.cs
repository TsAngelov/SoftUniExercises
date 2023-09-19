using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int toys = puzzles + dolls + teddybears + minions + trucks;
            double priceToys = puzzles * 2.60 + dolls * 3 + teddybears * 4.10 + minions * 8.20 + trucks * 2;
            if (toys >= 50)
            {
                priceToys = priceToys - priceToys * 0.25;    
            }
            double moneyLeft = priceToys - priceToys * 0.1;
            if ( moneyLeft >= excursionPrice)
            {
                double moneyLeft2 = moneyLeft - excursionPrice;
                Console.WriteLine($"Yes! {moneyLeft2:F2} lv left.");
            }
            else
            {
                double moneyNeeded = excursionPrice - moneyLeft;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
