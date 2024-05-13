using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int previousSum = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
            int maxDifference = 0;
            for (int i = 1; i < numbers; i++)
            {
                int currentSum = int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine());
                if (Math.Abs(previousSum - currentSum) > maxDifference)
                {
                    maxDifference = Math.Abs(previousSum - currentSum);
                }
                previousSum = currentSum;
            }
            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value={previousSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}
