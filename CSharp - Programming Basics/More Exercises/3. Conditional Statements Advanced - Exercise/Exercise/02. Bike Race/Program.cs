using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string race = Console.ReadLine();
            double sum = 0;
            switch (race)
            {
                case "trail":
                    sum += junior * 5.5 + senior * 7;
                    break;
                case "cross-country":
                    sum += junior * 8 + senior * 9.5;
                    if (junior+senior >=50)
                        sum -= sum * 0.25;
                    break;
                case "downhill":
                    sum += junior * 12.25 + senior * 13.75;
                    break;

                case "road":
                    sum += junior * 20 + senior * 21.5;
                    break;
            }
            sum -= sum * 0.05;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
