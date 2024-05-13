namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                int sum = i % 10 + i / 10;
                bool isTrue = false;
                if (sum == 5 || sum == 7 || sum == 11)
                    isTrue = true;
                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}