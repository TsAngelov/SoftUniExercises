using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine()), washingCount = 1, pots = 0, plates = 0;
            int quantity = bottles * 750;
            while (quantity >= 0)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine($"Detergent was enough!");
                    Console.WriteLine($"{plates} dishes and {pots} pots were washed.");
                    Console.WriteLine($"Leftover detergent {quantity} ml.");
                    break;
                }
                int dishes = int.Parse(input);
                if (washingCount % 3 == 0)
                {
                    pots += dishes;
                    quantity -= dishes * 15;
                }
                else
                {
                    plates += dishes;
                    quantity -= dishes * 5;
                }
                washingCount++;
            }
            if (quantity < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(quantity)} ml. more necessary!");
            }
        }
    }
}
