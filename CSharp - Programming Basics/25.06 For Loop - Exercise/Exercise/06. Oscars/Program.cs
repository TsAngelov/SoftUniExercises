using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string judge = Console.ReadLine();
                double pointsGiven = double.Parse(Console.ReadLine());
                points += (judge.Length * pointsGiven)/2;
                if (points >= 1250.5)
                {
                    break;
                }
            }
            if (points < 1250.5)
            {
                double diff = 1250.5 - points;
                Console.WriteLine($"Sorry, {actor} you need {diff:f1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
            }
        }
    }
}
