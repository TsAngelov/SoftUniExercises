using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumNeeded = int.Parse(Console.ReadLine()), payment = 1;
            double CS = 0, CC = 0, countCS = 0, countCC = 0, sumReached = 0;
            while (sumNeeded > sumReached)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    break;
                }
                int money = int.Parse(input);
                if (payment % 2 == 0)
                {
                    if (money >= 10)
                    {
                        CC += money;
                        countCC++;
                        sumReached += money;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }        
                }
                else 
                {
                    if (money <= 100)
                    {
                        CS += money;
                        countCS++;
                        sumReached += money;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }  
                }
                payment++;
            }
            if (sumReached >= sumNeeded)
            {
                Console.WriteLine($"Average CS: {CS/countCS:f2}");
                Console.WriteLine($"Average CC: {CC/countCC:f2}");
            }
        }
    }
}
