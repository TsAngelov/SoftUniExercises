namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "1":
                        int number = int.Parse(input[1]);
                        stack.Push(number);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        if (stack.Count > 0)
                        {
                            int max = int.MinValue;
                            foreach (var num in stack)
                            {
                                if (num > max)
                                {
                                    max = num;
                                }
                            }
                            Console.WriteLine(max);
                        }
                        break;
                    case "4":
                        if (stack.Count > 0)
                        {
                            int min = int.MaxValue;
                            foreach (var num in stack)
                            {
                                if (num < min)
                                {
                                    min = num;
                                }
                            }
                            Console.WriteLine(min);
                        }
                        break;
                }
            }
            Stack<int> stack2 = new Stack<int>(stack.Reverse());
            Console.WriteLine(string.Join(", ", stack2));
        }
    }
}
