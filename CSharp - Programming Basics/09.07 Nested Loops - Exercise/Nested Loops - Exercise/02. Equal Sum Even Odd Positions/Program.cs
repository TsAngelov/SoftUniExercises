using System;
using System.Collections.Immutable;

namespace _02._Equal_Sum_Even_Odd_Positions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                int currentNumber = i;
                bool odd = true;
                while (currentNumber > 0)
                {
                    int lastdigit = currentNumber % 10;
                    currentNumber /= 10;
                    if (odd) 
                    { 
                        oddSum += lastdigit;
                        odd = false;
                    }
                    else 
                    {
                        evenSum += lastdigit;
                        odd = true;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
