using System;

namespace _10._Odd_Even_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int odd = 0;
            int even = 0;
            for (int i = 0; i < n; i++)
            {
                int check = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    even += check;
                }
                else
                {
                    odd += check;
                }
            }
            if (odd == even)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                int diff = odd - even;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }
        }
    }
}
