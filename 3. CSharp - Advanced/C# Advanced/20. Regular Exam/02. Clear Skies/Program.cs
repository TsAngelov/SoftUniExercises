using System.Reflection;
using System.Threading;

namespace _02._Clear_Skies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] airspace = new char[n, n];

            int jetRow = 0, jetCol = 0, enemies = 0,
                armor = 300;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    airspace[i, j] = line[j];
                    if (line[j] == 'J')
                    {
                        jetRow = i;
                        jetCol = j;
                        airspace[i, j] = '-';
                    }
                    else if (line[j] == 'E') enemies++;
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up": jetRow--; break;
                    case "down": jetRow++; break;
                    case "left": jetCol--; break;
                    case "right": jetCol++; break;
                }

                if (airspace[jetRow, jetCol] == 'E')
                {
                    if (enemies == 1)
                    {
                        Console.WriteLine("Mission accomplished, you neutralized the aerial threat!");
                        break;
                    }
                    else
                    {
                        airspace[jetRow, jetCol] = '-';
                        armor -= 100;
                        enemies--;
                        if (armor == 0)
                        {
                            Console.WriteLine($"Mission failed, your jetfighter was shot down! Last coordinates [{jetRow}, {jetCol}]!");
                            break;
                        }
                    }
                }
                if (airspace[jetRow, jetCol] == 'R')
                {
                    armor = 300;
                    airspace[jetRow, jetCol] = '-';
                }
            }

            airspace[jetRow, jetCol] = 'J';

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(airspace[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
