using System;

namespace _04._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int time = hours * 60 + minutes;
            time += 30;
            double newHours = time / 60;
            if (newHours > 23) {newHours = 0;}
            Console.WriteLine($"{newHours}:{time%60:D2}");
        }
    }
}
