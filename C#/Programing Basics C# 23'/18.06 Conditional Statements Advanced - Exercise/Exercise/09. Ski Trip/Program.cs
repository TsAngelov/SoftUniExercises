using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine())-1;
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;
            double discount = 1;
            switch (room)
            {
                case "room for one person":
                    {
                        price = 18 * days;
                        switch (rating)
                        {
                            case "positive":
                                price = price + price * 0.25;
                                break;
                            case "negative":
                                discount = 0.10;
                                price = price - price * discount;
                                break;
                        }
                        break;
                    }
                    break;
                case "apartment":
                    {
                        price = 25 * days;
                        if (days < 10)
                        {
                            discount = 0.3;
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            discount = 0.35;
                        }
                        else
                        {
                            discount = 0.5;
                        }
                        price = price - price * discount;
                        switch (rating)
                        {
                            case "positive":
                                price = price + price * 0.25;
                                break;
                            case "negative":
                                price = price - price * 0.1;
                                break;
                        }
                        break;
                    }
                    break;
                case "president apartment":
                    {
                        price = 35 * days;
                        if (days < 10)
                        {
                            discount = 0.1;
                        }
                        else if (days >= 10 && days <= 15)
                        {
                            discount = 0.15;
                        }
                        else
                        {
                            discount = 0.20;
                        }
                        price = price - price * discount;
                        switch (rating)
                        {
                            case "positive":
                                price = price + price * 0.25;
                                break;
                            case "negative":
                                price = price - price * 0.1;
                                break;
                        }
                        break;
                    }
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
