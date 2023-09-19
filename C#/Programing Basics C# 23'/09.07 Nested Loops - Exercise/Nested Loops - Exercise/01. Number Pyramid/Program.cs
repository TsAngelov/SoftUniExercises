using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbersForRow = 1;
            int currentNumber = 1;
            while (currentNumber <= n)
            {
                for (int i = 0; i < numbersForRow; i++)
                {
                    if (currentNumber > n)
                    {
                        break;
                    }
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                numbersForRow++;
                Console.WriteLine();
            }
        }
    }
}
