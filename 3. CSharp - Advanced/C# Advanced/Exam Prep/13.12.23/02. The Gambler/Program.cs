namespace _02._The_Gambler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] gameBoard = new char[n, n];

            int gamblerEarnings = 100; // entering the game with 100
            int gamblerRow = -1, gamblerCol = -1;

            bool gamblerLeaves = false;
            bool jackpotHit = false;

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    gameBoard[i, j] = line[j];
                    if (line[j] == 'G')
                    {
                        gamblerRow = i;
                        gamblerCol = j;
                        gameBoard[i, j] = '-';
                    }
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (jackpotHit)
                {
                    break;
                }
                if (input == "up" && gamblerRow - 1 < 0 ||
                    input == "down" && gamblerRow + 1 == n ||
                    input == "left" && gamblerCol - 1 < 0 ||
                    input == "right" && gamblerCol + 1 == n)
                {
                    gamblerEarnings = 0;
                    Console.WriteLine("Game over! You lost everything!");
                    gamblerLeaves = true;
                    break;
                }
                switch (input)
                {
                    case "up":
                        gamblerRow--;
                        break;
                    case "down":
                        gamblerRow++;
                        break;
                    case "left":
                        gamblerCol--;
                        break;
                    case "right":
                        gamblerCol++;
                        break;
                }

                switch (gameBoard[gamblerRow, gamblerCol])
                {
                    case 'W':
                        gamblerEarnings += 100;
                        gameBoard[gamblerRow, gamblerCol] = '-';
                        break;
                    case 'P':
                        gamblerEarnings -= 200;
                        gameBoard[gamblerRow, gamblerCol] = '-';
                        break;
                    case 'J':
                        gamblerEarnings += 100000;
                        Console.WriteLine("You win the jackpot!");
                        jackpotHit = true;
                        break;
                }
                if (gamblerEarnings <= 0)
                {
                    gamblerLeaves = true;
                    break;
                }
            }

            gameBoard[gamblerRow, gamblerCol] = 'G';
            if (gamblerLeaves)
            {
                Console.WriteLine("Game over! You lost everything!");
            }
            else
            {
                Console.WriteLine($"End of the game. Total amount: {gamblerEarnings}$");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(gameBoard[i,j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
