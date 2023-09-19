using System;
using System.Threading;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int coins = 0;
            while (money > 0) 
            {
                if (money >= 2)
                {
                    money -= 2;
                }
                else if (money >= 1)
                {
                    money -= 1;
                }
                else if (money >= 0.5m)
                {
                    money -= 0.5m;
                }
                else if (money >= 0.2m)
                {
                    money -= 0.2m;
                }
                else if (money >= 0.1m)
                {
                    money -= 0.1m;
                }
                else if (money >= 0.05m)
                {
                    money -= 0.05m;
                }
                else if (money >= 0.02m)
                {
                    money -= 0.02m;
                }
                else
                    money -= 0.01m;
                coins++;
            }
            Console.WriteLine(coins);
        }
    }
}
