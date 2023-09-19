using System;

namespace _05._Average_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double input = 0, average = 0;
            for (int i = 0; i < number; i++) 
            {
                input = double.Parse(Console.ReadLine());
                average += input;
            }
            average /= number;
            Console.WriteLine($"{average:f2}");
        }
    }
}
