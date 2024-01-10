namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> newStack = new Stack<int>();

            //newStack.Push(5);
            //newStack.Push(53);
            //newStack.Push(1);
            //newStack.Push(17);

            ////int topElement = newStack.Pop();

            ////Console.WriteLine(topElement);

            ////Console.WriteLine(newStack.Pop());

            //while (newStack.Count != 0)
            //{
            //    int topElement = newStack.Pop();
            //    Console.WriteLine(topElement);
            //}

            Queue<string> tickets = new Queue<string>();

            tickets.Enqueue("Poruchkata mi e greshna");
            tickets.Enqueue("Poruchkata mi q izqde dostavchika");
            tickets.Enqueue("Hranata mi grumna");

            //Console.WriteLine(tickets.Dequeue());
            //Console.WriteLine(tickets.Dequeue());

            while (tickets.Count > 0) 
            {
                string element = tickets.Dequeue();

                Console.WriteLine(element);
            }
        }
    }
}
