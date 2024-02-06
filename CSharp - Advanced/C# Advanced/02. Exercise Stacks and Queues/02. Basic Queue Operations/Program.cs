namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if(queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallest = int.MaxValue;
                foreach (int number in queue)
                {
                    if (number < smallest)
                    {
                        smallest = number;
                    }
                }
                Console.WriteLine(smallest);
            }
        }
    }
}
