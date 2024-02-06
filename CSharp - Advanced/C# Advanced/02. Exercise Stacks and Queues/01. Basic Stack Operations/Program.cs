namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = int.MaxValue;
                foreach (var item in stack)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
