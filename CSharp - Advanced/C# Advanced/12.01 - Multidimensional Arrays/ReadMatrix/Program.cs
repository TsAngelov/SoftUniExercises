namespace ReadMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            //for (int row = 0; row < rows; row++) 
            //{
            //    for (int col = 0; col < cols; col++)
            //    {
            //        matrix[row,col] = int.Parse(Console.ReadLine());
            //    }
            //}

            for (int row = 0; row < rows; row++)
            {
                int[] arrayRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }
        }
    }
}
