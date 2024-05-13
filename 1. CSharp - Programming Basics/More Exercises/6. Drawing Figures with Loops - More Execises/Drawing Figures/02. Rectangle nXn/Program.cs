using System;

namespace _02._Rectangle_nXn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentRow = 1;
            while (currentRow <= n) 
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                currentRow++;
            }
        }
    }
}
