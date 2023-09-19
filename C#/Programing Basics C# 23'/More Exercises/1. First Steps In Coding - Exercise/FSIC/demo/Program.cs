using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()) * 100;
            double height = double.Parse(Console.ReadLine()) * 100;
            double desks = Math.Floor(((height - 100) / 70));
            double rows = Math.Floor(width / 120);
            double spaces = desks * rows - 3;
            Console.WriteLine(spaces);
        }
    }
}
