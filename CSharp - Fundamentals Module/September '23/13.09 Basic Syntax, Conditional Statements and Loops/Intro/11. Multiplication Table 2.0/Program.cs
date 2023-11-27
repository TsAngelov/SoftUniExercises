using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            for (int i = times; i <= 10; i++)
            {
                Console.WriteLine($"{integer} X {i} = {integer * i}");
            }
            if (times > 10)
            {
                Console.WriteLine($"{integer} X {times} = {integer * times}");
            }
        }
    }
}
