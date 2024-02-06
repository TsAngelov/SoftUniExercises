namespace _02._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = info[0];
            int cols = info[1];

            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] currentRow = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = char.Parse(currentRow[col]);
                }
            }

            int matched = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row,col] == matrix[row,col + 1] && matrix[row,col] == matrix[row + 1,col] && matrix[row,col] == matrix[row + 1, col + 1])
                    {
                        matched++;
                    }
                }
            }
            Console.WriteLine(matched);
        }
    }
}
