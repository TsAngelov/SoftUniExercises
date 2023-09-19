using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string attempt = Console.ReadLine();
            while (attempt != password)
            {
                attempt = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
