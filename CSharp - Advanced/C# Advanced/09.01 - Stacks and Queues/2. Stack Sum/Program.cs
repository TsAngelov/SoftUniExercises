namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(numbers);

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] split = command.Split(' ');
                int first = int.Parse(split[1]);
                if (split[0] == "add")
                {
                    int second = int.Parse(split[2]);

                    stack.Push(first);
                    stack.Push(second);
                }
                else
                {
                    if (stack.Count >= first)
                    {
                        for (int i = 0; i < first; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
