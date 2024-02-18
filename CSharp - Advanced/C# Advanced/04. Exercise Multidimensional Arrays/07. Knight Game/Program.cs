namespace _07._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int knightsRemoved = 0;
            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0, colMostAttacking = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackKnights = CountAttackedKnights(row, col);
                            if (countMostAttacking < attackKnights)
                            {
                                countMostAttacking = attackKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;
                            }
                        }

                    }
                }

                if (countMostAttacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }
            }
            Console.WriteLine(knightsRemoved);

        }
        int CountAttackedKnights(int row, int col, char[] matrix,)
        {
            int attackedKnights = 0;

            if (IsCellValid(row - 1, col - 2))
            {
                if ()
                {

                }
            }
            return attackedKnights;
        }

        bool IsCellValid(int row, int col)
        {
            return
                row >= 0
                && row < n
                && col >= 0
                && col < n;
        }
    }
}
