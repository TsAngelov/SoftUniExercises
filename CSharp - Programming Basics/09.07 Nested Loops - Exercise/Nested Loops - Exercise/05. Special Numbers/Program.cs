using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                bool isMagic = true;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    int lastdigit = currentNumber % 10;
                    currentNumber /= 10;
                    if (lastdigit == 0)
                    { 
                        isMagic = false;
                        break; 
                    }
                    if (n % lastdigit != 0)
                    {
                        isMagic = false;
                        break;
                    }
                }
                if (isMagic)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
