using System;

namespace FSIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (b1 + b2) * h / 2;
            string areaSNULA = area.ToString("0.00");
            Console.WriteLine(areaSNULA);
        }
    }
}
