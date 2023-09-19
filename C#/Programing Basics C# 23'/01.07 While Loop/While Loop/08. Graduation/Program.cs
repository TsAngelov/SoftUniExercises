using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 1;
            double gradeSum = 0;
            int excluded = 0;
            bool isExcluded = false;
            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    grades++;
                    gradeSum += grade;
                }
                else
                {
                    excluded++;
                }
                if (excluded > 1)
                {
                    isExcluded = true;
                    break;
                }
            }
            if (isExcluded) 
            {
                Console.WriteLine($"{name} has been excluded at {grades} grade");
            }
            else
            {
                double average = gradeSum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
