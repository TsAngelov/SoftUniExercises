using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            double gradeSum = 0;
            int problem = 0, gradeBad = 0;
            string lastProblem = "";
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Enough")
                {
                    double average = gradeSum / problem;
                    Console.WriteLine($"Average score: {average:f2}");
                    Console.WriteLine($"Number of problems: {problem}");
                    Console.WriteLine($"Last problem: {lastProblem}");
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                problem++;
                if (grade <= 4)
                    gradeBad++;
                if (gradeBad == badGrades) 
                {
                    Console.WriteLine($"You need a break, {gradeBad} poor grades.");
                    break;
                }
                lastProblem = input;
            }
        }
    }
}
