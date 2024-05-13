using System;
using System.Xml;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            double toyMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += i * 10;
                    savedMoney -= 1;
                }
                else
                {
                    toyMoney += toyPrice;
                }
            }

            savedMoney += toyMoney;

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine("Yes! {0:F2}", savedMoney - washingMachinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:F2}", washingMachinePrice - savedMoney);
            }
        }
    }
}
