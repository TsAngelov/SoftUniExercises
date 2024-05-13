using System;
using System.ComponentModel;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowerNum = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;
            switch (flowers)
            {
                case "Roses":
                    price = flowerNum * 5;
                    if (flowerNum > 80)
                    {
                        price = price - price * 0.1;
                    }
                    break;
                case "Dahlias":
                    price = flowerNum * 3.8;
                    if (flowerNum > 90)
                    {
                        price = price - price * 0.15;
                    }
                    break;
                case "Tulips":
                    price = flowerNum * 2.8;
                    if (flowerNum > 80)
                    {
                        price = price - price * 0.15;
                    }
                    break;
                case "Narcissus":
                    price = flowerNum * 3;
                    if (flowerNum < 120)
                    {
                        price = price + price * 0.15;
                    }
                    break;
                case "Gladiolus":
                    price = flowerNum * 2.5;
                    if (flowerNum < 80)
                    {
                        price = price + price * 0.2;
                    }
                    break;
            }
            if (price <= budget)
            {
                price = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {flowerNum} {flowers} and {price:f2} leva left.");
            }
            else
            {
                price = price - budget;
                Console.WriteLine($"Not enough money, you need {price:f2} leva more.");
            }
        }
    }
}
