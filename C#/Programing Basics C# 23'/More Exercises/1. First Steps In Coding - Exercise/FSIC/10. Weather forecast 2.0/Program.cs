using System;

namespace _10._Weather_forecast_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            // 35.00 - 26.00 = Hot
            // 25.9 - 20.1 = Warm
            // 20.00 - 15.00 = Mild
            // 14.9 - 12.00 = Cool
            // 11.9 - 5.00 = Cold

            if (degrees <= 35 && degrees >= 26) 
            {
                Console.WriteLine("Hot");
            }
            else if (degrees <= 25.9 && degrees >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (degrees <= 20.00 && degrees >= 15.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degrees <= 14.9 && degrees >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (degrees <= 11.9 && degrees >= 5)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}