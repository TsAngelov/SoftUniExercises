using System;

namespace _08._Point_on_Rectangle_Border
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine()), y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (x == x1 || x == x2)
            {
                if (y1 <= y && y <= y2)
                {
                    Console.WriteLine($"Border");

                }
                else
                    Console.WriteLine("Inside / Outside");
            }
            else if (y == y1 || y == y2)
            {

                if (x1 <= x && x <= x2)
                {
                    Console.WriteLine($"Border");
                }
                else
                    Console.WriteLine("Inside / Outside");
            }
            else
                Console.WriteLine("Inside / Outside");
        }
    }
}
