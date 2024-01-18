namespace _03._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = info[0];
            int cols = info[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int biggestSum = 0;
            int biggestSumRow = 0;
            int biggestSumCol = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            currentSum += matrix[row + i, col + j];
                        }
                    }
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        biggestSumRow = row;
                        biggestSumCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = biggestSumRow; row < biggestSumRow + 3; row++)
            {
                for (int col = biggestSumCol; col < biggestSumCol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
