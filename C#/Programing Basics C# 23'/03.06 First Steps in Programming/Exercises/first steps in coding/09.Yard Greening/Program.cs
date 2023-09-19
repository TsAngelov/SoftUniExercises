using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double price = meters * 7.61;
            double discount = price * 0.18;
            double discountedPrice = price - discount;
            Console.WriteLine($"The final price is: {discountedPrice} lv.");
            Console.Write($"The discount is: {discount} lv.");
        }
    }
}