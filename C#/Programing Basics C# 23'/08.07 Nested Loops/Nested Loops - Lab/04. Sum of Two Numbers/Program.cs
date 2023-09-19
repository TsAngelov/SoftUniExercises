using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int magicN = int.Parse(Console.ReadLine()), n = 0;
            bool flag = false;
            for (int i = first; i <= last; i++)
            {
                for (int i2 = first; i2 <= last; i2++)
                {
                    n++;
                    if (i+i2 == magicN)
                    {
                        Console.WriteLine($"Combination N:{n} ({i} + {i2} = {magicN})");
                        flag = true;
                        break;
                    }   
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"{n} combinations - neither equals {magicN}");
            }
        }
    }
}
