using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int lengthEpisode = int.Parse(Console.ReadLine());
            int lengthBreak = int.Parse(Console.ReadLine());
            double lunchTime = lengthBreak * 0.125;
            double restTime = lengthBreak * 0.25;
            double timeLeft = lengthBreak - lunchTime - restTime;
            if (timeLeft >= lengthEpisode) 
            {
                timeLeft = timeLeft - lengthEpisode;
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                double timeNeeded = lengthEpisode - timeLeft;
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(timeNeeded)} more minutes.");
            }
                
        }
    }
}
