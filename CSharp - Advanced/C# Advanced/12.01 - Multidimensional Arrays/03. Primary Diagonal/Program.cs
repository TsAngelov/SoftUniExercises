﻿namespace _03._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[0];

            int[,] matrix = ReadMatrix(rows, cols, " ");

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                sum += matrix[row, row];
            }

            Console.WriteLine(sum);

            int[,] ReadMatrix(int rows, int cols, string separator)
            {
                int[,] matrix = new int[rows, cols];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int[] arrayRow = Console.ReadLine().Split(separator).Select(int.Parse).ToArray();
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = arrayRow[col];
                    }
                }
                return matrix;
            }
        }
    }
}
