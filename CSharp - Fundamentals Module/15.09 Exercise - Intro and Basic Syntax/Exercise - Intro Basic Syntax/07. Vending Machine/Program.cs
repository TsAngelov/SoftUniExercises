using System.Data.SqlTypes;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0;
            while (input != "Start")
            {
                double coin = double.Parse(input);
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    money += coin;
                    input = Console.ReadLine();
                    continue;
                }
            }
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                double price = 0;
                switch (input)
                {
                    case "Nuts": price = 2.0; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1.0; break;
                }
                if (price == 0)
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                else
                {
                    if (money - price < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        flag = false;
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                        continue;
                    }
                }
            }
                Console.WriteLine($"Change: {money:f2}");
        }
    }
}