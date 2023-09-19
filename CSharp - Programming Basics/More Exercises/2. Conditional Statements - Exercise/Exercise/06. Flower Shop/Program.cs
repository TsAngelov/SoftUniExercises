using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int ziumbiuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            double money = magnolii * 3.25 + ziumbiuli * 4 + roses * 3.50 + cactuses * 8;
            double moneyAfterTaxes = money - money * 0.05;
            if (moneyAfterTaxes >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(moneyAfterTaxes - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - moneyAfterTaxes)} leva.");
            }
        }
    }
}
