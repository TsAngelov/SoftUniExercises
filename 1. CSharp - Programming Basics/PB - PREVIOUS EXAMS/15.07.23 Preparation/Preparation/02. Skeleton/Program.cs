using System;

namespace _02._Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlM = int.Parse(Console.ReadLine());
            int controlS = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int hundredS = int.Parse(Console.ReadLine());

            double control = controlM * 60 + controlS;
            double timeReduce = distance / 120;
            double totalReduced = timeReduce * 2.5;
            double timeMarin = (distance / 100) * hundredS - totalReduced;
            if (timeMarin <= control)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {timeMarin:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {Math.Abs(control-timeMarin):f3} second slower.");
            }
        }
    }
}
