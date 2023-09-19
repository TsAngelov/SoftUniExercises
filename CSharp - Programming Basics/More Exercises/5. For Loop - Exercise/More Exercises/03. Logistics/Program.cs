using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());
            double cargoSum = 0, microbus = 0, truck = 0, train = 0;
            double average = 0;
            for (int i = 1; i <= cargo; i++)
            {
                int tonnage = int.Parse(Console.ReadLine());
                cargoSum += tonnage;
                if (tonnage <= 3)
                {
                    microbus += tonnage;
                }
                else if (tonnage <= 11)
                {
                    truck += tonnage;
                }
                else
                {
                    train += tonnage;
                }
            }
            average = ((microbus * 200) + (truck * 175) + (train * 120)) / cargoSum;
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{microbus/cargoSum*100:f2}%");
            Console.WriteLine($"{truck/cargoSum*100:f2}%");
            Console.WriteLine($"{train /cargoSum*100:f2}%");
        }
    }
}
