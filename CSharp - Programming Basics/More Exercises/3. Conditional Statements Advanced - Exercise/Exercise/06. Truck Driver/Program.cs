using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine()), salary = 0;
            if (kilometers <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = 0.75 * kilometers;
                        break;
                    case "Summer":
                        salary = 0.9 * kilometers;
                        break;
                    case "Winter":
                        salary = 1.05 * kilometers;
                        break;
                }
            }
            else if (kilometers <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        salary = 0.95 * kilometers;
                        break;
                    case "Summer":
                        salary = 1.1 * kilometers;
                        break;
                    case "Winter":
                        salary = 1.25 * kilometers;
                        break;
                }
            }
            else
                salary = 1.45 * kilometers;
            salary = salary * 4;
            Console.WriteLine($"{salary-salary*0.1:f2}");
        }
    }
}
