namespace ReadMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string separator = Console.ReadLine();

            int[,] matrix = ReadMatrix(rows, cols, separator);

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

            //for (int row = 0; row < rows; row++) 
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row,col] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int row = 0; row < rows; row++)
            //{
            //    int[] arrayRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row, col] = arrayRow[col];
            //    }
            //}


        }
    }
}
