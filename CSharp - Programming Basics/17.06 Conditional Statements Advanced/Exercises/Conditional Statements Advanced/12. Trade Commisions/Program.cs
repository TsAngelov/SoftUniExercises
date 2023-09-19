using System;

namespace _12._Trade_Commisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            switch (city)
            {
                case "Sofia":
                    if (volume >= 0 && volume <= 500)
                    {
                        Console.WriteLine($"{(volume * 0.05):f2}");
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        Console.WriteLine($"{(volume * 0.07):f2}");
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        Console.WriteLine($"{(volume * 0.08):f2}");
                    }
                    else if (volume > 10000)
                    {
                        Console.WriteLine($"{(volume * 0.12):f2}");
                    }
                        
                    else
                        Console.WriteLine("error");
                    break;
                case "Varna":
                    if (volume >= 0 && volume <= 500)
                    {
                        Console.WriteLine($"{(volume * 0.045):f2}");
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        Console.WriteLine($"{(volume * 0.075):f2}");
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        Console.WriteLine($"{(volume * 0.1):f2}");
                    }
                    else if (volume > 10000)
                    {
                        Console.WriteLine($"{(volume * 0.13):f2}");
                    }
                    else
                        Console.WriteLine("error");
                    break;

                case "Plovdiv":
                    if (volume >= 0 && volume <= 500)
                    {
                        Console.WriteLine($"{(volume * 0.055):f2}");
                    }
                    else if (volume > 500 && volume <= 1000)
                    {
                        Console.WriteLine($"{(volume * 0.08):f2}");
                    }
                    else if (volume > 1000 && volume <= 10000)
                    {
                        Console.WriteLine($"{(volume * 0.12):f2}");
                    }
                    else if (volume > 10000)
                    {
                        Console.WriteLine($"{(volume * 0.145):f2}");
                    }
                    else
                        Console.WriteLine("error");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
