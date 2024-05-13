namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = ReadMatrix(rows, cols, " ");

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

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
