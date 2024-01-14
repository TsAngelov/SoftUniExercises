namespace _08._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Count() % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> charStack = new();
            foreach (char c in input) 
            {
                if ("{([".Contains(c))
                {
                    charStack.Push(c);
                }
                else if (c == ')' && charStack.Peek() == '(')
                {
                    charStack.Pop();
                }
                else if (c == '}' && charStack.Peek() == '{')
                {
                    charStack.Pop();
                }
                else if (c == ']' && charStack.Peek() == '[')
                {
                    charStack.Pop();
                }
            }

            Console.WriteLine(charStack.Any() ? "NO" : "YES");
        }
    }
}
