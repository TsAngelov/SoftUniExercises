using System;

namespace _05._Square_Border
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string top = "+ ";
            string bottom = "+ ";
            for (int i = 0; i < n-2; i++)
            {
                top += "- ";
            }
            top += "+";
            Console.WriteLine(top);

            for (int i = 0; i < n-2; i++)
            {
                string middle = "| ";
                for (int j = 0; j < n-2 ; j++)
                {
                    middle += "- ";
                }
                middle += "|";
                Console.WriteLine(middle);
            }
            bottom = top;
            Console.WriteLine(bottom);
        }
    }
}
