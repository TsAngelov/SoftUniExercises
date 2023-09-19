using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            switch (projection)
            {
                case "Premiere":
                    Console.WriteLine($"{rows*columns*12:f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{rows * columns * 7.5:f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{rows * columns * 5:f2} leva");
                    break;
                default:
                    break;
            }
        }
    }
}
