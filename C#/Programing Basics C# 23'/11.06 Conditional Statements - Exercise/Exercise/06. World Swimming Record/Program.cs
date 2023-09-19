    using System;

    namespace _06._World_Swimming_Record
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double record = double.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                double timeMeter = double.Parse(Console.ReadLine());
                double time = distance * timeMeter;
                double timeSlow = Math.Floor(distance / 15) * 12.5;
                double totalTime = time + timeSlow;
                if (totalTime < record)
                {
                    Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
                }
                else
                    Console.WriteLine($"No, he failed! He was {totalTime-record:F2} seconds slower.");
            }
        }
    }
