﻿using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input!="End")
            {
                double budget = double.Parse(Console.ReadLine());
                double money = 0;
                while (money < budget)
                { 
                    money += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {input}!");
                input = Console.ReadLine();
            }
        }
    }
}
