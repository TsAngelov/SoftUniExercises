namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> newStack = new Stack<int>();

            newStack.Push(5);
            newStack.Push(53);
            newStack.Push(1);
            newStack.Push(17);

            //int topElement = newStack.Pop();

            //Console.WriteLine(topElement);

            //Console.WriteLine(newStack.Pop());

            while (newStack.Count != 0)
            {
                int topElement = newStack.Pop();
                Console.WriteLine(topElement);
            }
        }
    }
}
