namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            TopNumber(n);
        }
        static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (DivisibleBy8(i) && HoldsOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DivisibleBy8(int n)
        {
            int sumDigits = 0;
            while (n > 0)
            {
                sumDigits += n % 10;
                n /= 10;
            }
            if (sumDigits % 8 == 0)
                return true;
            else
                return false;
        }
        static bool HoldsOddDigit(int n)
        {
            while (n > 0)
            {
                if (n % 2 != 0)
                    return true;
                n /= 10;
            }
            return false;
        }
    }
}