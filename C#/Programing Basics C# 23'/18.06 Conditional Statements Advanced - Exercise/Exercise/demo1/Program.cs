using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 5;
            double discount = 0.5;
            a = a - a * 0.3;
            a = a - a * 0.2;
            b = b - b * 0.5;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
