using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int pieces = length * width;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{pieces} pieces are left.");
                    break;
                }
                int take = int.Parse(input);
                pieces -= take;
                if (pieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }
            }
        }
    }
}
