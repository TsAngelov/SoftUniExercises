using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7, healed = 0, unhealed = 0, left = 0;
            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i%3==0)
                {
                    if (unhealed > healed)
                    {
                        doctors++;
                    }
                }
                if (patients <= doctors)
                {
                    healed += patients;
                }
                else
                {
                    unhealed += patients - doctors;
                    left = patients - doctors;
                    healed += patients - left;
                }
            }
            Console.WriteLine($"Treated patients: {healed}.");
            Console.WriteLine($"Untreated patients: {unhealed}.");
        }
    }
}
