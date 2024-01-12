namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(numbers);
            int biggestOrder = int.MinValue;
            while (orders.Count > 0)
            {
                int currentOrder = orders.First();
                if (currentOrder <= quantity)
                {
                    quantity -= currentOrder;
                    if (currentOrder > biggestOrder)
                    {
                        biggestOrder = currentOrder;
                    }
                }
                else
                {
                    break;
                }
                orders.Dequeue();
            }
            if (orders.Count > 0)
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }
            else
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
