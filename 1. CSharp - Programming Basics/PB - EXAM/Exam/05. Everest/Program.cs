using System;

namespace _05._Everest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int days = 1; int meters = 5364;
            while (input != "END")
            {
                if (input == "Yes") days++;
                if (days > 5)
                {
                    if (meters >= 8848)
                        Console.WriteLine($"Goal reached for {days} days!");
                    else
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine(meters);
                    }
                    break;
                }
                meters += int.Parse(Console.ReadLine());
                if (meters >= 8848)
                {
                    Console.WriteLine($"Goal reached for {days} days!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "END")
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(meters);
            }
        }
    }
}
