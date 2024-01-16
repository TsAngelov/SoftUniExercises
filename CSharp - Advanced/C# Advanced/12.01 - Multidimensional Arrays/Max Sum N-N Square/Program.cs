namespace Max_Sum_N_N_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = ReadMatrix(rows, cols, " ");
            int maxSquareSum = 0;
            int maxSquareRow = 0;
            int maxSquareCol = 0;

            int[] inputSearch = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rowsSearching = inputSearch[0];
            int colsSearching = inputSearch[1];
            for (int row = 0; row <= rows -  rowsSearching; row++)
            {
                for (int col = 0; col <= cols - colsSearching; col++)
                {
                    int currentSum = 0;
                    for (int rowInside = 0; rowInside < rowsSearching; rowInside++)
                    {
                        for (int colInside = 0; colInside < colsSearching; colInside++)
                        {
                            currentSum += matrix[row + rowInside, col + colInside];
                        }
                    }

                    if (currentSum > maxSquareSum)
                    {
                        maxSquareSum = currentSum;
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }

            for (int currentRow = 0; currentRow < rowsSearching; currentRow++)
            {
                for (int currentCol = 0; currentCol < colsSearching; currentCol++)
                {
                    Console.Write($"{matrix[maxSquareRow + currentRow, maxSquareCol + currentCol]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSquareSum);

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
