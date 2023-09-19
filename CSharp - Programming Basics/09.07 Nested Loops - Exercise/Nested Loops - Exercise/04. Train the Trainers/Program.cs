using System;

namespace _04._Train_the_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            int projectCount = 0;
            double totalGrades = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {totalGrades/(projectCount*judges):f2}.");
                    break;
                }
                double currentGrades = 0;
                for (int i = 1; i <= judges; i++)
                {
                    currentGrades += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{input} - {currentGrades/judges:f2}.");
                projectCount++;
                totalGrades += currentGrades;
            }
        }
    }
}
