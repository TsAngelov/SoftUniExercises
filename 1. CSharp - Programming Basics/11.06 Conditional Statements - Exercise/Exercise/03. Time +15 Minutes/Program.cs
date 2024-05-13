using System;
using System.Threading.Channels;

namespace _03._Time__15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int time = hours * 60 + minutes;
            int newTime = time + 15;
            int newHours = newTime / 60;
            int newMinutes = newTime % 60;    
            if (newHours > 23)
            {
                newHours = 0;
            }
            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
        }
    }
}
