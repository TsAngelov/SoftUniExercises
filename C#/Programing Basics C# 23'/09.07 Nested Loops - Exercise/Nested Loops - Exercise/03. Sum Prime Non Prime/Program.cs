using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int number = int.Parse(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isNumberPrime = true;
                for (int i = 2; i < number; i++)
                {
                    if (number%i==0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }
                if (isNumberPrime) { primeSum += number; }
                else { nonPrimeSum += number; }
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
