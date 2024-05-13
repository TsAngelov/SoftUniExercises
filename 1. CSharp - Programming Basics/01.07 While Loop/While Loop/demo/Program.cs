using System;
using System.Collections;
using System.ComponentModel;

namespace softuni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int gradeCounter = 1;
            double totalGrade = 0;
            int excludedGrade = 0;
            bool isExcluded = false;

            while (gradeCounter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    totalGrade += grade;
                    gradeCounter++;
                }
                else
                {
                    excludedGrade = gradeCounter;
                    isExcluded = true;
                    break;
                }
            }

            if (isExcluded)
            {
                Console.WriteLine($"{studentName} has been excluded at {excludedGrade} grade");
            }
            else
            {
                double averageGrade = totalGrade / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}