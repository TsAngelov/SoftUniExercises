using System;

namespace _06._Multiply_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstNumber = number % 10; number /= 10;
            int secondNumber = number % 10; number /= 10;
            int thirdNumber = number % 10;
            for (int a = 1; a <= firstNumber; a++)
            {
                for (int b = 1; b <= secondNumber; b++)
                {
                    for (int c = 1; c <= thirdNumber; c++)
                    {
                        Console.WriteLine($"{a} * {b} * {c} = {a*b*c};");
                    }
                }
            }
        }
    }
}
