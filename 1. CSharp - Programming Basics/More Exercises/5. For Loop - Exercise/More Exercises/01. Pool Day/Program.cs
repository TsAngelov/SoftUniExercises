using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine()), age = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0) inheritance -= 12000;
                else inheritance -= 12000 + age * 50;
                age++;
            }
            if (inheritance < 0) Console.WriteLine($"He will need {Math.Abs(inheritance):f2} dollars to survive.");
            else Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:f2} dollars left.");
        }
    }
}
