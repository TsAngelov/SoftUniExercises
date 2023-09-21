namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255, filled = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters + filled > capacity || liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                    filled += liters;
            }
            Console.WriteLine(filled);
        }
    }
}