using System;

namespace _06._Star_Romb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int interval = 1; interval <=n-row; interval++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int stars = 1; stars <= row-1; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = n-1; row >= 1; row--)
            {
                for (int interval = 1; interval <= n-row; interval++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int stars = 1; stars <=row-1; stars++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
