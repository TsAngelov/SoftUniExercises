using System;

namespace _01._Rectangle_10x10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stars = 0;
            while (stars < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("*");
                }
                stars++;
                Console.WriteLine();
            }
        }
    }
}
