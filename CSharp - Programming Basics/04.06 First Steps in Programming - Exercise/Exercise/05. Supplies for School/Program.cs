using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());
            double totalSum = pens * 5.80 + markers * 7.20 + liters * 1.20;
            double discountedSum = totalSum * percent / 100;
            Console.WriteLine(totalSum-discountedSum);
        }
    }
}