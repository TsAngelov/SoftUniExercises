using System;
using System.Text;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double f = 5;
            Console.WriteLine("{0:F3}", f);
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            bool isValid = a == b;
            Console.WriteLine(isValid);

            a = b;
            Console.WriteLine(isValid);

            isValid = a == b;
            Console.WriteLine(isValid);
        }
    }
}
