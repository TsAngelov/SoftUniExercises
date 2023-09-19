using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tourneys = int.Parse(Console.ReadLine());
            double startPoints = double.Parse(Console.ReadLine()), points = 0;
            var w =0;
            for (int i = 0; i < tourneys; i++)
            {
                string placement = Console.ReadLine();
                if (placement == "W") { points += 2000; w++; }
                else if (placement == "F") { points += 1200; }
                else if (placement == "SF") { points += 720; } 
            }
            Console.WriteLine($"Final points: {points+startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(points/tourneys)}");
            Console.WriteLine($"{w/tourneys*100:f2}%");
        }
    }
}
