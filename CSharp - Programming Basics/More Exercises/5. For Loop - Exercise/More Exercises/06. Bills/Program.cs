using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double electricity = 0, water = 0, internet = 0, other = 0, average = 0;
            for (int i = 1; i <= months; i++)
            {
                double price = double.Parse(Console.ReadLine());
                electricity += price;
            }
            water = months * 20;
            internet = months * 15;
            other = (electricity + water + internet) * 0.2 + electricity + water + internet;
            average = (water + internet + other + electricity) / months;
            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
