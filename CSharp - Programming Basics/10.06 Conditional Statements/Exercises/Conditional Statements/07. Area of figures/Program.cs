using System;
using System.Drawing;
using System.Security.Cryptography;

namespace _07._Area_of_figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area;
            if (shape == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(area.ToString("0.000"));
            }
            else if (shape == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(area.ToString("0.000"));
            }
            else if (shape == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine(area.ToString("0.000"));
            }
            else if (shape == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (a * h) / 2;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
