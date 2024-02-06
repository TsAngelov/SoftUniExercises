namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascalTriange = new long[n][];
            pascalTriange[0] = new long[1] {1};

            for (int row = 1; row < pascalTriange.Length; row++)
            {
                pascalTriange[row] = new long[row + 1];
                for (int col = 0; col < pascalTriange[row].Length; col++)
                {
                    long numberDiag, numberAbove; // numberDiag - The number before the number above
                    if (col == 0)
                    {
                        pascalTriange[row][col] = 1; // The first number is always 1
                    }
                    else if (col == pascalTriange[row].Length - 1)
                    {
                        pascalTriange[row][col] = 1; // The last number is always 1
                    }
                    else
                    {
                        numberDiag = pascalTriange[row - 1][col-1];
                        numberAbove = pascalTriange[row - 1][col];
                        pascalTriange[row][col] = numberDiag + numberAbove;
                    }
                }
            }
            for (int row = 0; row < pascalTriange.Length; row++)
            {
                Console.WriteLine(string.Join(" ", pascalTriange[row]));
            }
        }
    }
}
