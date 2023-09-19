namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int hCount = 0, mCount = 0, kCount = 0, dCount = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0) hCount++;
                if (i % 3 == 0) mCount++;
                if (i % 6 == 0)
                {
                    kCount++;
                    if (kCount % 2 == 0) dCount++;
                }
            }
            Console.WriteLine($"Rage expenses: {(hCount * headsetPrice) + (mousePrice * mCount) + (kCount * keyboardPrice) + (dCount * displayPrice):f2} lv.");
        }
    }
}