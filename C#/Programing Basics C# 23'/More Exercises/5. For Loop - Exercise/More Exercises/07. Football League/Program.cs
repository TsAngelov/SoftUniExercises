using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            double fans = int.Parse(Console.ReadLine());
            double a = 0, b = 0, v = 0, g = 0;
            for (int i = 1; i <= fans; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                switch (sector)
                {
                    case 'A': a++; break;
                    case 'B': b++; break;
                    case 'V': v++; break;
                    case 'G': g++; break;
                }
            }
            Console.WriteLine($"{a/fans*100:f2}%");
            Console.WriteLine($"{b/fans*100:f2}%");
            Console.WriteLine($"{v/fans*100:f2}%");
            Console.WriteLine($"{g/fans*100:f2}%");
            Console.WriteLine($"{fans/capacity*100:f2}%");
        }
    }
}
