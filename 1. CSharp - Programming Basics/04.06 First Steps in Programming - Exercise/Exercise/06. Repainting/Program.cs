using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalCost = (nylon + 2) * 1.50 + (paint + paint * 0.10)*14.50 + thinner*5.00 + 0.40;
            double costBuilder = (totalCost*0.3) * hours ;
            Console.WriteLine(totalCost + costBuilder);
        }
    }
}