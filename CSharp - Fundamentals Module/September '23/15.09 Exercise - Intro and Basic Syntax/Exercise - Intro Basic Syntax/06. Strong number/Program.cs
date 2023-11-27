namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = 0, powerNum = 1, num = number;
            int power = 0;
            while (number != 0)
            {
                n = number % 10;
                for (int i = n; i >=1; i--)
                {
                    powerNum *= i;
                }
                power += powerNum;
                powerNum = 1;
                number /= 10;
            }
            if (power == num)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}