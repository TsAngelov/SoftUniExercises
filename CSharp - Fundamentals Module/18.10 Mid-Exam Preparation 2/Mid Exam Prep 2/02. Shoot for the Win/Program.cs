﻿namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            int targetsShot = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int index = int.Parse(input);
                if (index >= 0 && index < targets.Count)
                {

                }
                else
                {
                }
            }
        }
    }
}