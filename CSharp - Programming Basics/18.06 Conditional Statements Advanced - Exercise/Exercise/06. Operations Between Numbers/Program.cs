using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            switch (op)
            {
                case "+":
                    result = n1 + n2;
                    Console.WriteLine(result % 2 == 0
                        ? $"{n1} + {n2} = {result} - even"
                        : $"{n1} + {n2} = {result} - odd");
                    break;
                case "-":
                    result = n1 - n2;
                    Console.WriteLine(result % 2 == 0
                        ? $"{n1} - {n2} = {result} - even"
                        : $"{n1} - {n2} = {result} - odd");
                    break;
                case "*":
                    result = n1 * n2;
                    Console.WriteLine(result % 2 == 0
                        ? $"{n1} * {n2} = {result} - even"
                        : $"{n1} * {n2} = {result} - odd");
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
