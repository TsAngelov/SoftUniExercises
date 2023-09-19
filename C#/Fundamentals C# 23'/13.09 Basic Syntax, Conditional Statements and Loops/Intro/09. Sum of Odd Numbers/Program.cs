using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0, n = 0;
            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
                n++;
                if (n == number)
                    break;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
