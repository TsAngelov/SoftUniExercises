using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine()) / 100;
            double sum = deposit + term * ((deposit * percentage) / 12);
            Console.WriteLine(sum);
        }
    }
}