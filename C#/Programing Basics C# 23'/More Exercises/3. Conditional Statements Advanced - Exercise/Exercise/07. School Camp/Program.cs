using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(), group = Console.ReadLine(), sport = "";
            int pupils = int.Parse(Console.ReadLine()), nights = int.Parse(Console.ReadLine());
            double priceNight = 0;
            switch (season)
            {
                case "Winter":
                    switch (group)
                    {
                        case "boys":
                        case "girls": priceNight = 9.60; break;
                        default: priceNight = 10; break;
                    } break;
                case "Spring":
                    switch (group)
                    {
                        case "boys":
                        case "girls": priceNight = 7.20; break;
                        default: priceNight = 9.5; break;
                    } break;
                case "Summer":
                    switch (group)
                    {
                        case "boys":
                        case "girls": priceNight = 15; break;
                        default: priceNight = 20; break;
                    } break;
            }
            double price = priceNight * nights * pupils;
            if (pupils >= 50) price -= price * 0.5;
            else if (pupils >= 20) price -= price * 0.15;
            else if (pupils >= 10) price -= price * 0.05;
            switch (group)
            {
                case "girls":
                    switch (season)
                    {
                        case "Winter": sport = "Gymnastics"; break;
                        case "Spring": sport = "Athletics"; break;
                        case "Summer": sport = "Volleyball"; break;
                    } break;
                case "boys":
                    switch (season)
                    {
                        case "Winter": sport = "Judo"; break;
                        case "Spring": sport = "Tennis"; break;
                        case "Summer": sport = "Football"; break;
                    } break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter": sport = "Ski"; break;
                        case "Spring": sport = "Cycling"; break;
                        case "Summer": sport = "Swimming"; break;
                    } break;
                    
            }
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
