using System;

namespace _10._Odd_Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddMin = 1000000000.0;
            double oddMax = -1000000000.0;
            double evenMin = 1000000000.0;
            double evenMax = -1000000000.0;
            double evenSum = 0; double oddSum = 0;
            for (int i = 1; i <=n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number <= evenMin)
                    {
                        evenMin = number;
                    }
                    if (number >= evenMax)
                    {
                        evenMax = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number <= oddMin)
                    {
                        oddMin = number;
                    }
                    if (number >= oddMax)
                    {
                        oddMax = number;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == 1000000000.0)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else { Console.WriteLine($"OddMin={oddMin:f2},"); }
            if (oddMax == -1000000000.0)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else { Console.WriteLine($"OddMax={oddMax:f2},"); }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == 1000000000.0)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else { Console.WriteLine($"EvenMin={evenMin:f2},"); }
            if (evenMax == -1000000000.0)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else { Console.WriteLine($"EvenMax={evenMax:f2}"); }
        }
    }
}
