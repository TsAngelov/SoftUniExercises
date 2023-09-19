using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int daysSpending = 0, days = 0;
            while (true)
            {
                string action = Console.ReadLine();
                days++;
                switch (action) 
                {
                    case "spend":
                        money -= double.Parse(Console.ReadLine());
                        if (money < 0)
                            money = 0;
                        daysSpending++;
                        break;
                    case "save":
                        money += double.Parse(Console.ReadLine());
                        daysSpending = 0;
                        break;
                }
                if (daysSpending == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(days);
                    break;
                }
                else if (money >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
        }
    }
}
