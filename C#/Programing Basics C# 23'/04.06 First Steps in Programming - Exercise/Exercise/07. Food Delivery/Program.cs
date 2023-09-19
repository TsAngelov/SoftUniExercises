using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegaterianMenus = int.Parse(Console.ReadLine());
            double totalSum = chickenMenus * 10.35 + fishMenus * 12.40 + vegaterianMenus * 8.15;
            double desert = totalSum * 0.2;
            Console.WriteLine(totalSum + desert + 2.50);
        }
    }
}