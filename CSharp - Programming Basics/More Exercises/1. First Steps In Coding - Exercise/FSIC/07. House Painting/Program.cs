using System;

namespace _07._House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double backWall = x * x;
            double frontWall = (x * x) - (1.2 * 2);

            double sideWalls =2 * ((x * y) - (1.5 * 1.5));

            double roof = 2 * (x * y) + 2 * ((x * h) / 2);

            double paintRoof = roof / 4.3;
            double paintWalls = (backWall + frontWall + sideWalls) / 3.4;

            string WallsSNULI = paintWalls.ToString("0.00");
            string RoofSNULI = paintRoof.ToString("0.00");

            Console.WriteLine(WallsSNULI);
            Console.WriteLine(RoofSNULI);
        }
    }
}
