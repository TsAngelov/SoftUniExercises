using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int time = hour * 60 + minute;
            int hourArrived = int.Parse(Console.ReadLine());
            int minuteArrived = int.Parse(Console.ReadLine());
            int timeArrived = hourArrived * 60 + minuteArrived;
            int hourNew = 0;
            int minuteNew = 0;
            if (timeArrived > time)
            {
                if (timeArrived > time)
                {
                    hourNew = (timeArrived - time) / 60;
                    minuteNew = (timeArrived - time) % 60;
                    if (timeArrived - time >= 60)
                    {
                        Console.WriteLine("Late");
                        if (minuteNew < 10)
                        {
                            Console.WriteLine($"{hourNew}:0{minuteNew} hours after the start");
                        }
                        else
                            Console.WriteLine($"{hourNew}:{minuteNew} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{minuteNew} minutes after the start");
                    }              
                }
            }  
            else 
            {
                hourNew = (time - timeArrived) / 60;
                minuteNew = (time - timeArrived) % 60;
                if (time - timeArrived <=30) 
                {
                    Console.WriteLine("On time");
                    if (time != timeArrived)
                    {
                        Console.WriteLine($"{minuteNew} minutes before the start");
                    }
                }
                else
                {
                    if (time - timeArrived >=60)
                    {
                        Console.WriteLine("Early");
                        if (minuteNew < 10)
                        {
                            Console.WriteLine($"{hourNew}:0{minuteNew} hours before the start");
                        }
                        else
                            Console.WriteLine($"{hourNew}:{minuteNew} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{minuteNew} minutes before the start");
                    }
                }
            }
        }
    }
}
