namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> expressions = new Stack<string>(input.Reverse());

            int result = int.Parse(expressions.Pop());
            while (expressions.Count != 0)
            {
                string op = expressions.Pop();
                int currentNumber = int.Parse(expressions.Pop());

                if (op == "+")
                    result += currentNumber;
                else
                    result -= currentNumber;
            }
            Console.WriteLine(result);
        }
    }
}
