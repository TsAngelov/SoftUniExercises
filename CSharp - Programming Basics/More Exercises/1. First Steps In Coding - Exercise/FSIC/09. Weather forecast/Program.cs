﻿using System;

namespace _09._Weather_forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
                Console.WriteLine("It's cold outside!");
        }
    }
}
