using System;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()) * 100;
            double height = double.Parse(Console.ReadLine()) * 100;
            double remainderHeight = (height - 100) % 70;  //20
            double desks = ((height - 100) - remainderHeight) / 70;   // 790 - 20 /70 = 770 / 70
            double remainderWidth = width % 120;
            double rows = (width - remainderWidth) / 120;
            Console.WriteLine(rows * desks - 3);
        }
    }
}