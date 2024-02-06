namespace _04._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = info[0];
            int cols = info[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] matrixInput = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = matrixInput[col];
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();
                if (command[0] == "swap")
                {
                    if (command.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    int firstRow = int.Parse(command[1]);
                    int firstCol = int.Parse(command[2]);
                    int secondRow = int.Parse(command[3]);
                    int secondCol = int.Parse(command[4]);

                    if (firstRow < 0 || firstRow >= rows ||  secondRow < 0 || secondRow >= rows ||
                        firstCol < 0 || firstCol >= cols || secondCol < 0 || secondCol >= cols)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string tempValue = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = tempValue;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
