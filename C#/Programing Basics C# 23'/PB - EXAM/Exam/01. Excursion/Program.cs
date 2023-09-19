using System;

namespace _01._Excursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double price = people *(nights * 20 + cards * 1.6 + tickets * 6);
            price += price * 0.25;
            Console.WriteLine($"{price:f2}");
        }
    }
}
