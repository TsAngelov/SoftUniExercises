using System;

namespace _04._Vegetable_exchange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double weightVegetables = double.Parse(Console.ReadLine());
            double weightFruits = double.Parse((Console.ReadLine()));
            double totalSum = (priceVegetables * weightVegetables + priceFruits * weightFruits) / 1.94;
            string SUMSNULI = totalSum.ToString("0.00");
            Console.WriteLine(SUMSNULI);
        }
    }
}
