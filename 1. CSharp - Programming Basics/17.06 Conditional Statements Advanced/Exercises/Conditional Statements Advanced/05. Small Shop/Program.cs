using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    {
                        switch (product)
                        {
                            case "coffee":
                                Console.WriteLine(0.50 * amount);
                                break;
                            case "water":
                                Console.WriteLine(0.80 * amount);
                                break;
                            case "beer":
                                Console.WriteLine(1.20 * amount);
                                break;
                            case "sweets":
                                Console.WriteLine(1.45 * amount);
                                break;
                            case "peanuts":
                                Console.WriteLine(1.60 * amount);
                                break;
                        }
                        break;
                    }
                case "Plovdiv":
                    {
                        switch (product)
                        {
                            case "coffee":
                                Console.WriteLine(0.40 * amount);
                                break;
                            case "water":
                                Console.WriteLine(0.70 * amount);
                                break;
                            case "beer":
                                Console.WriteLine(1.15 * amount);
                                break;
                            case "sweets":
                                Console.WriteLine(1.30 * amount);
                                break;
                            case "peanuts":
                                Console.WriteLine(1.50 * amount);
                                break;
                        }
                    }
                        break;
                case "Varna":
                    {
                        switch (product)
                        {
                            case "coffee":
                                Console.WriteLine(0.45 * amount);
                                break;
                            case "water":
                                Console.WriteLine(0.70 * amount);
                                break;
                            case "beer":
                                Console.WriteLine(1.10 * amount);
                                break;
                            case "sweets":
                                Console.WriteLine(1.35 * amount);
                                break;
                            case "peanuts":
                                Console.WriteLine(1.55 * amount);
                                break;
                        }
                    }
                    break;
            }
        }
    }
}
