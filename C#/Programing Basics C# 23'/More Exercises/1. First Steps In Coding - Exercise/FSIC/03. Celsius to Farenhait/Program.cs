using System;

namespace _03._Celsius_to_Farenhait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());
            double farenhait = celcius * 9 / 5 + 32;
            string farenhaitSNULI = farenhait.ToString("0.00");
            Console.WriteLine(farenhaitSNULI);
        }
    }
}
