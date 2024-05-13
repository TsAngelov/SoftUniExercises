namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string input;
            string[] delims = { ", ", " " };

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(delims, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        stack.Push(int.Parse(command[i]));
                    }
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine("No elements");
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
