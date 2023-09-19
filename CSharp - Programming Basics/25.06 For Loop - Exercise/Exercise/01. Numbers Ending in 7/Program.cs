using System;

namespace _01._Numbers_Ending_in_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
