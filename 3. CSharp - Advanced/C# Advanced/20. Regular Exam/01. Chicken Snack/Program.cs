namespace _01._Chicken_Snack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> moneyAmount = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> prices = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int foodCount = 0;
            int change = 0;
            while (true)
            {
                if (prices.Count == 0 || moneyAmount.Count == 0)
                {
                    break;
                }
                int currentMoney = moneyAmount.Pop() + change;
                int currentPrice = prices.Dequeue();

                change = 0;

                if (currentMoney == currentPrice)
                {
                    foodCount++;
                }
                if (currentMoney > currentPrice)
                {
                    foodCount++;
                    change = currentMoney - currentPrice;
                }
            }
            if (foodCount >= 4)
            {
                Console.WriteLine($"Gluttony of the day! Henry ate {foodCount} foods.");
            }
            else if (foodCount >= 1)
            {
                if (foodCount == 1)
                {
                    Console.WriteLine($"Henry ate: {foodCount} food.");
                }
                else
                {
                    Console.WriteLine($"Henry ate: {foodCount} foods.");
                }
            }
            else
            {
                Console.WriteLine("Henry remained hungry. He will try next weekend again.");
            }
        }
    }
}
