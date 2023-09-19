using System;
using System.Xml;

namespace _04._Password_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guess = Console.ReadLine();
            string password = "s3cr3t!P@ssw0rd";
            if (guess == password) 
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
