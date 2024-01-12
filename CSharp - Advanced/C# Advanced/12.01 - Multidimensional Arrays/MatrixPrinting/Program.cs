namespace MatrixPrinting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = // new int[4, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 },
                {10,11,12 },
            };

            Console.WriteLine($"Rows: {matrix.GetLength(0)}");
            Console.WriteLine($"Cols: {matrix.GetLength(1)}");

            for (int row = 0; matrix.GetLength(0) < 4; row++)
            {

                for (int col = 0; matrix.GetLength(1) < 3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
