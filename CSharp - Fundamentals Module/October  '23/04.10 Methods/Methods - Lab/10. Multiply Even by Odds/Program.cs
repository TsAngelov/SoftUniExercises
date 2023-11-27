namespace _10._Multiply_Even_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));

        }
        static int GetMultipleOfEvenAndOdds(int number)
        {
            int result = 0;
            result = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
            return result;

        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                if (number%10 % 2 == 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                if (number % 10 % 2 != 0)
                {
                    sum += number % 10;
                }
                number /= 10;
            }
            return sum;
        }
    }
}