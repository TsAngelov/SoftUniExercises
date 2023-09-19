using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = ((bookPages / pages) / days);
            Console.WriteLine(hours);
        }
    }
}