namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(numbers);
            int biggestOrder = orders.Max();
            while (orders.Count != 0)
            {
                int currentOrder = orders.Peek();
                if (currentOrder <= quantity)
                {
                    quantity -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(biggestOrder);
            if (orders.Count > 0)      
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            else
                Console.WriteLine("Orders complete");
        }
    }
}
