﻿using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int time = projects * 3;
            Console.WriteLine("The architect " + name + " will need " + time + " hours to complete " + projects + " project/s.");
            Console.WriteLine($"The architect {name} will need {time} hours to complete );
        }
    }
}