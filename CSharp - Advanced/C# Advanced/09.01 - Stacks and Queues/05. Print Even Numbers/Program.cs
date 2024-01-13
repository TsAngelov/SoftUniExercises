namespace _05._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Queue<string> queue = new Queue<string>(input);
            Queue<int> output = new Queue<int>();

            while (queue.Count != 0)
            {
                int currentNumber = int.Parse(queue.Dequeue());
                if (currentNumber % 2 == 0)
                {
                    output.Enqueue(currentNumber);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
