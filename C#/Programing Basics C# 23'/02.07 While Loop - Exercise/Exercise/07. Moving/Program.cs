using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;
            int boxes = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    Console.WriteLine($"{volume - boxes} Cubic meters left.");
                    break;
                }
                boxes += int.Parse(input);
                if (boxes > volume)
                {
                    Console.WriteLine($"No more free space! You need {boxes - volume} Cubic meters more.");
                    break;
                }
            }
        }
    }z
}
