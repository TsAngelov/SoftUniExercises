using System;
using System.Data;
using System.Linq;

namespace _02._Mouse_in_the_kitchen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int rows = rowCol[0];
            int cols = rowCol[1];

            char[,] matrix = new char[rows, cols];
            int mouseRow = -1, mouseCol = -1;
            int cheeseCount = 0;

            for (int i = 0; i < rows; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                    if (line[j] == 'M')
                    {
                        mouseRow = i;
                        mouseCol = j;
                        matrix[i, j] = '*';
                    }
                    if (line[j] == 'C')
                    {
                        cheeseCount++;
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "danger")
            {
                if (input == "left" && mouseCol == 0 ||
                    input == "right" && mouseCol == matrix.GetLength(1) - 1 ||
                    input == "up" && mouseRow == 0 ||
                    input == "down" && mouseRow == matrix.GetLength(0) - 1)
                {
                    Console.WriteLine("No more cheese for tonight!");
                    break;
                }
                else
                {
                    switch (input) 
                    {
                        case "left" when matrix[mouseRow, mouseCol - 1] == '@':
                        case "right" when matrix[mouseRow, mouseCol + 1] == '@':
                        case "up" when matrix[mouseRow - 1, mouseCol] == '@':
                        case "down" when matrix[mouseRow + 1, mouseCol] == '@':
                            continue;
                        case "left":
                            mouseCol--;
                            break;
                        case "right":
                            mouseCol++;
                            break;
                        case "up":
                            mouseRow--;
                            break;
                        case "down":
                            mouseRow++;
                            break;
                    }
                    if (matrix[mouseRow,mouseCol] == 'C')
                    {
                        cheeseCount--;
                        matrix[mouseRow, mouseCol] = '*';
                        if (cheeseCount == 0)
                        {
                            Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                            break;
                        }
                    }
                    if (matrix[mouseRow, mouseCol] == 'T')
                    {
                        Console.WriteLine("Mouse is trapped!");
                        break;
                    }
                }
            }
            if (input == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
            }
            matrix[mouseRow, mouseCol] = 'M';

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
