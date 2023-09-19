using System;
using System.ComponentModel;

namespace _04._Clever_Lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine()), money = 0, remainder = 0;
            int priceToy = int.Parse(Console.ReadLine()), toys = 0;
            for (int i = 1; i <=age; i++)
            {
                if (i%2==0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += priceToy;
                }
            }
            if (money >= price)
            {
                remainder = money - price;
                Console.WriteLine($"Yes! {remainder:f2}");
            }
            else
            {
                remainder = price - money;
                Console.WriteLine($"No! {remainder:f2}");
            }
        }
    }
}
