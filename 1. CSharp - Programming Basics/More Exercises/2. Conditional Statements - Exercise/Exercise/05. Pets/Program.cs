using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine())/1000;
            double food = dogFood * days + catFood * days + turtleFood * days;
            if (food <= foodLeft) 
            {
                Console.WriteLine($"{Math.Floor(foodLeft - food)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(food-foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
