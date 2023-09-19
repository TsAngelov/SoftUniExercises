using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double tax;
            if (km < 20)                       //taxi
            {
                if (time == "day")                      //day
                {
                    tax = 0.7 + 0.79 * km;
                }
                else                                   //night
                {
                    tax = 0.7 + 0.90 * km;
                }
            }
            else if (km < 100)                       //bus
            {
                tax = 0.09 * km;
            }
            else                                //train
            {
                tax = 0.06 * km;
            }
            Console.WriteLine($"{tax:F2}");
        }
    }
}
