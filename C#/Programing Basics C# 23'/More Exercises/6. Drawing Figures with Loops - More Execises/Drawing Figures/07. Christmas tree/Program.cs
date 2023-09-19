using System;

namespace _07._Christmas_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++) 
            {
                for (int a = n-i; a <=  n-1; a++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
