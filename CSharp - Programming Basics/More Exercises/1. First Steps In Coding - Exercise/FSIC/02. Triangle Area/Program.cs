using System;

namespace _02._Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a * h / 2;
            string areaSNULI = area.ToString("0.00");
            Console.WriteLine(areaSNULI);
        }
    }
}
