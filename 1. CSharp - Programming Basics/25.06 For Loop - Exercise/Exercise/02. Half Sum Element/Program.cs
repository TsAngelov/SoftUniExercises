using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int largest = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > largest)
                {
                    largest = num;
                }
                sum += num;
            }
            sum -= largest;
            if (sum == largest)
            {
                Console.WriteLine($"Yes");
                Console.Write($"Sum = {largest}");
            }
            else
            {
                int diff = sum - largest;
                Console.WriteLine("No");
                Console.Write($"Diff = {Math.Abs(diff)}");
            }
        }
    }
}
