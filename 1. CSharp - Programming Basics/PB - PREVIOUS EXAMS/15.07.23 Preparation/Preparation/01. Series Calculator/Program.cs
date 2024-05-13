using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double watch = seasons * (episodes * (length + 0.2 * length) + 10);
            Console.WriteLine($"Total time needed to watch the {serial} series is {watch} minutes.");
        }
    }
}
