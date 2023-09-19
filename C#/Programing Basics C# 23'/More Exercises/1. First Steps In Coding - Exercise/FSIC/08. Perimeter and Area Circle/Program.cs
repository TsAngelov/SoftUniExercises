using System;

namespace _08._Perimeter_and_Area_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * r * r;
            double circleParameter = 2 * Math.PI * r;

            string AreaSNULI = circleArea.ToString("0.00");
            string ParaSNULI = circleParameter.ToString("0.00");

            Console.WriteLine(AreaSNULI);
            Console.WriteLine(ParaSNULI);
        }
    }
}
