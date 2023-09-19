using System;

namespace _04._Grandpa_Stavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalLiters = 0, degrees = 0, liters = 0;
            for (int i = 1; i <= days; i++)
            {
                liters = double.Parse(Console.ReadLine());
                totalLiters += liters;
                degrees += double.Parse(Console.ReadLine()) * liters;
            }
            double averageDegrees = degrees / totalLiters;
            Console.WriteLine($"Liter: {totalLiters:f2}");
            Console.WriteLine($"Degrees: {averageDegrees:f2}");

            if (averageDegrees < 38)
                Console.WriteLine($"Not good, you should baking!");
            else if (averageDegrees <= 42)
                Console.WriteLine("Super!");
            else
                Console.WriteLine($"Dilution with distilled water!");
        }
    }
}
