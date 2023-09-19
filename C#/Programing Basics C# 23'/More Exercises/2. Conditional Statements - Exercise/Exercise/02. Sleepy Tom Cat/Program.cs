using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());
            int workDays = 365 - restDays;
            int playingTime = workDays * 63 + restDays * 127;
            if (playingTime <= 30000)
            {
                int difference = 30000 - playingTime;
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else 
            {
                int difference = playingTime - 30000;
                int hours = difference / 60;
                int minutes = difference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
