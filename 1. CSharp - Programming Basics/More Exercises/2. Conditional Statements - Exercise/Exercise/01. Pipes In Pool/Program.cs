using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int debit1st = int.Parse(Console.ReadLine());
            int debit2nd = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double pipe1 = debit1st * hours;
            double pipe2 = debit2nd * hours;
            double filled = pipe1+pipe2;
            if (filled <= volume) 
            {
                double percentageFull = (filled * 100 / volume);
                double percentage1st = (pipe1*100/filled);
                double percentage2nd = (pipe2*100/filled);
                Console.WriteLine($"The pool is {percentageFull:F2}% full. Pipe 1: {percentage1st:F2}%. Pipe 2: {percentage2nd:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours:F2} hours the pool overflows with {filled-volume:F2} liters.");
            }

        }
    }
}
