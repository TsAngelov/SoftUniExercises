using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double sneakers = tax - 0.4 * tax;
            double outfit = sneakers - sneakers * 0.2;
            double basketball = outfit / 4;
            double accesories = basketball / 5;
            Console.WriteLine(tax + sneakers + outfit + basketball + accesories);
        }
    }
}