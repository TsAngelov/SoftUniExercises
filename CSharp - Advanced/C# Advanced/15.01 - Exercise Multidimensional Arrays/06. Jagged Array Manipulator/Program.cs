namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0.5;
            int numberf = 3;

            Console.WriteLine(number + numberf);
            Console.WriteLine(number - numberf);
            int n = int.Parse(Console.ReadLine());
            double[][] matrix = new double[n][];

            for (int row = 0; row < n; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int row = 0; row < n - 1; row++)
            {
                if (matrix[row].Length == matrix[row+1].Length)
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] *= 2;
                        matrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < matrix[row].Length; i++)
                    {
                        matrix[row][i] /= 2;
                    }
                    for (int i = 0; i < matrix[row + 1].Length; i++)
                    {
                        matrix[row + 1][i] /= 2;
                    }
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = Console.ReadLine().Split();
                int row = int.Parse(info[1]);
                int col = int.Parse(info[2]);
                int value = int.Parse(info[3]);
                switch (info[0])
                {
                    case "Add":
                        if (AreValidIndices(matrix, row, col, n))
                        {
                            matrix[row][col] += value;
                        }
                        break;
                    case "Subtract":
                        if (AreValidIndices(matrix, row, col, n))
                        {
                            matrix[row][col] -= value;
                        }
                        break;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }
        }
        static bool AreValidIndices(double[][] matrix, int currentRow, int currentCol, int rows)
        {
            if (currentRow < 0 || currentRow >= rows || currentCol < 0 || currentCol >= matrix[currentRow].Length)
            {
                return false;
            }
            return true;
        }
    }
}
