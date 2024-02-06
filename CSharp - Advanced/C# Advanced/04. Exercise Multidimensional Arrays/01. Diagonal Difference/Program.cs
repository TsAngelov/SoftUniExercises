namespace _01._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row,col] = currentRow[col];
                }
            }

            int primaryDiagSum = 0;
            int secondaryDiagSum = 0;
            for (int i = 0; i < n; i++)
            {
                primaryDiagSum += matrix[i,i];
                secondaryDiagSum += matrix[i, n - i - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagSum - secondaryDiagSum));
        }
    }
}
