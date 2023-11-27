using System.Transactions;

namespace _08._Triangle_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            int numbersForRow = 1;
            while (currentNumber <= n)
            {
                for (int i = 0; i < numbersForRow; i++)
                {
                    Console.Write(currentNumber + " ");
                }
                numbersForRow++;
                currentNumber++;
                Console.WriteLine();
            }
        }
    }
}