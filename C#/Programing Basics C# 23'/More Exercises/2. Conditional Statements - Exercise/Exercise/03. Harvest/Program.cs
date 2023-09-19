using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyard = int.Parse(Console.ReadLine());
            double grapes1SM = double.Parse(Console.ReadLine());
            int neededLiters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grapes = vineyard * grapes1SM;
            double wine = 0.4 * grapes / 2.5;
            if (wine < neededLiters)
            {
                double remainingLiters = neededLiters - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(remainingLiters)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                double remainingLiters = wine - neededLiters;
                Console.WriteLine($"{Math.Ceiling(remainingLiters)} liters left -> {Math.Ceiling(Math.Ceiling(remainingLiters)/workers)} liters per person.");
            }
        }
    }
}
