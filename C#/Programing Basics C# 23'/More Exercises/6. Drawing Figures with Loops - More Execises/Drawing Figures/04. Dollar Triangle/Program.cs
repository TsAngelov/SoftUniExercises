using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentRow = 1;
            int signsRow = 1;
            while (currentRow <= n)
            {
                for (int i = 1; i <= signsRow; i++)
                {
                    Console.Write("$ ");
                }
                currentRow++;
                signsRow++;
                Console.WriteLine();
            }
        }
    }
}
