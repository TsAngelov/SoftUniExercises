namespace _04._Print_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            PrintTopPart(n);
            PrintBotPart(n);
        }

        static void PrintBotPart(int n)
        {
            for (int row = n - 1; row >= 0; row--)
            {
                PrintRow(row);
            }
        }

        static void PrintTopPart(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintRow(row);
            }
        }

        static void PrintRow(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(col + " ");
            }
            Console.WriteLine();
        }
    }
}