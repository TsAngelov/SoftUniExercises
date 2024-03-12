﻿namespace _01._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            try
            {
                if (number < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}
