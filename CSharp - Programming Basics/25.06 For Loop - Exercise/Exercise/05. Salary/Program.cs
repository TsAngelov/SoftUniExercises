using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i = 0; i < tabs; i++)
            {
                string tab = Console.ReadLine();
                if (tab == "Facebook")
                    salary -= 150;
                else if (tab == "Instagram")
                    salary -= 100;
                else if (tab == "Reddit")
                    salary -= 50;
                if (salary <= 0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
                Console.WriteLine(salary);
        }
    }
}
