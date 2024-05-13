using System;

namespace _02._Maiden_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double partyCost = double.Parse(Console.ReadLine());
            int loveWishes = int.Parse(Console.ReadLine());
            int waxRoses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int caricatures = int.Parse(Console.ReadLine());
            int luckySurprise = int.Parse(Console.ReadLine());
            double money = loveWishes * 0.6 + waxRoses * 7.2 + keychains * 3.6 + caricatures * 18.2 + luckySurprise * 22;
            if (loveWishes + waxRoses + keychains + caricatures + luckySurprise >= 25)
            {
                money -= money * 0.35;
            }
            money -= money * 0.1;
            if (money >= partyCost)
            {
                Console.WriteLine($"Yes! {money - partyCost:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {partyCost - money:f2} lv needed.");
            }
        }
    }
}
