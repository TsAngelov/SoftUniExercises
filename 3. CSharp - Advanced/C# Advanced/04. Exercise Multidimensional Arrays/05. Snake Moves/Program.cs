using System.Text;

namespace _05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = info[0];
            int cols = info[1];
            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            string tempSnake = snake;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (tempSnake == "")
                        {
                            tempSnake = snake;
                        }
                        matrix[row, col] = tempSnake[0];
                        tempSnake = tempSnake.Remove(0, 1);
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (tempSnake == "")
                        {
                            tempSnake = snake;
                        }
                        matrix[row, col] = tempSnake[0];
                        tempSnake = tempSnake.Remove(0, 1);
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
