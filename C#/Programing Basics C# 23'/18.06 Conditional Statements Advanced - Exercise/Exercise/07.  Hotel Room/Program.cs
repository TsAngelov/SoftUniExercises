using System;

namespace _07.__Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartmentPrice = 0, studioPrice = 0;
            switch (month)
            {
                case "May": case "October":
                    apartmentPrice = 65; studioPrice = 50;
                    if (nights > 7 && nights < 15)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    else if (nights > 14)
                    {
                        studioPrice -= studioPrice * 0.3; 
                    }
                    break;
                case "June": case "September":
                    apartmentPrice = 68.7; studioPrice = 75.2;
                    if (nights > 14)
                    {
                        studioPrice -= studioPrice * 0.2;
                    }
                    break;
                case "July": case "August":
                    apartmentPrice = 77; studioPrice = 76;
                    break;
            }
            if (nights > 14) 
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }
            Console.WriteLine($"Apartment: {apartmentPrice*nights:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice*nights:f2} lv.");
        }
    }
}
