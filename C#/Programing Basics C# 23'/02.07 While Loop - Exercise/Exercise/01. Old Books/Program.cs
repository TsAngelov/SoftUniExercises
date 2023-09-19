using System;
using System.Data;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bookCount = 0;
            while (true)
            {
                string book = Console.ReadLine();
                if (book == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {bookCount} books.");
                    break;
                }
                if (book == input)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }
                bookCount++;
            }
            
        }
    }
}
