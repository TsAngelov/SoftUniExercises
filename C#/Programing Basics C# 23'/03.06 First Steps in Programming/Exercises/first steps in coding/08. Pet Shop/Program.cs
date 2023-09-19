using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogPackets = int.Parse(Console.ReadLine());
            int catPackets = int.Parse(Console.ReadLine());
            double dogPrice = 2.50;
            int catPrice = 4;
            double total = dogPackets*dogPrice + catPackets*catPrice;
            Console.WriteLine($"{total} lv.");
        }
    }
}