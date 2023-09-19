using System;

namespace _05._Game_of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double result = 0, first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, invalid = 0, numbers = 0;
            for (int i = 1; i <= moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 50)
                {
                    result /= 2;
                    invalid++;
                }
                else if (number < 10)
                {
                    result += number * 0.2;
                    first++;
                }
                else if (number < 20)
                {
                    result += number * 0.3;
                    second++;
                }
                else if (number < 30)
                {
                    result += number * 0.4;
                    third++;
                }
                else if (number < 40)
                {
                    result += 50;
                    fourth++;
                }
                else
                {
                    result += 100;
                    fifth++;
                }
                numbers++;
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {first/numbers*100:f2}%");
            Console.WriteLine($"From 10 to 19: {second/numbers*100:f2}%");
            Console.WriteLine($"From 20 to 29: {third/numbers*100:f2}%");
            Console.WriteLine($"From 30 to 39: {fourth/numbers*100:f2}%");
            Console.WriteLine($"From 40 to 50: {fifth/numbers*100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalid/numbers*100:f2}%");
        }
    }
}
