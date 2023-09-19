using System;

namespace _06._Fish_exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double weightPalamud = double.Parse(Console.ReadLine());
            double weightSafrid = double.Parse(Console.ReadLine());
            int weightMidi = int.Parse(Console.ReadLine());
            double pricePalamud = (skumriqPrice * 0.6 + skumriqPrice) * weightPalamud;
            double priceSafrid = (cacaPrice * 0.8 + cacaPrice) * weightSafrid;
            double priceMidi = 7.5 * weightMidi;
            double sum = priceMidi + pricePalamud + priceSafrid;
            string sumSNULI = sum.ToString("0.00");
            Console.WriteLine(sumSNULI);
        }
    }
}
