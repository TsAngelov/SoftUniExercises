using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 10; number++)
            {
                for (int multiplier = 1; multiplier <= 10; multiplier++)
                {
                    Console.WriteLine($"{number} * {multiplier} = {number*multiplier}");
                }
            }
        }
    }
}
