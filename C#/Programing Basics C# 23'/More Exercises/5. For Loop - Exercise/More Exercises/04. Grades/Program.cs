using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double bad = 0, decent = 0, good = 0, great = 0;
            double average = 0;
            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                average += grade;
                if (grade < 3) bad++;
                else if (grade < 4) decent++;
                else if (grade < 5) good++;
                else great++;
            }
            Console.WriteLine($"Top students: {great/students*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {good/students*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {decent/students*100:f2}%");
            Console.WriteLine($"Fail: {bad/students*100:f2}%");
            Console.WriteLine($"Average: {average/students:f2}");
        }
    }
}
