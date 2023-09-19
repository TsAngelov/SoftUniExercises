using System;

namespace _05._Dog_Care
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodBought = int.Parse(Console.ReadLine())*1000;
            int foodGiven = 0;
            string input = Console.ReadLine();
            while (input != "Adopted")
            {
                int food = int.Parse(input);
                foodGiven += food;
                input = Console.ReadLine();
            }
            if (foodGiven <= foodBought )
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodBought-foodGiven} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodGiven-foodBought} grams more.");
            }
        }
    }
}
