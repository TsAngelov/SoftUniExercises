using System;
using System.Reflection;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hriz = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            double price = 0;
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());
            switch (season)
            {
                case "Spring":
                case "Summer":
                    price = hriz * 2 + roses * 4.1 + tulips * 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    price = hriz * 3.75 + roses * 4.5 + tulips * 4.15;
                    break;
            }
            if (holiday == 'Y')
                price += price * 0.15;
            if (tulips > 7 && season == "Spring")
                price -= price * 0.05;
            if (roses >= 10 && season == "Winter")
                price -= price * 0.1;
            if (hriz + roses + tulips > 20)
                price -= price * 0.2;
            price += 2;
            Console.WriteLine($"{price:f2}");
        }
    }
}
