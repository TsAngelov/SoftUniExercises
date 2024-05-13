namespace Stack_and_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Petar");
            linkedList.AddLast("Petar");

            queue.Enqueue("Patrona");
            linkedList.AddLast("Patrona");

            queue.Enqueue("Ocet Petrov");
            linkedList.AddLast("Ocet Petrov");

            queue.Enqueue("Ali");
            linkedList.AddLast("Ali");

            while (queue.Count != 0)
            {
                string element = queue.Dequeue();
                Console.WriteLine($"Queue: {element}");
            }

            LinkedListNode<string> node = linkedList.First;

            while (node != null)
            {
                Console.WriteLine($"Linked list: {node.Value}");
                linkedList.RemoveFirst();
                node = linkedList.First;
            }

            /////////////////////
            Console.WriteLine("\n");
            /////////////////////

            linkedList = new LinkedList<string>();

            Stack<string> stack = new Stack<string>();

            stack.Push("Petar");
            linkedList.AddFirst("Petar");

            stack.Push("Patrona");
            linkedList.AddFirst("Patrona");

            stack.Push("Ocet Petrov");
            linkedList.AddFirst("Ocet Petrov");

            stack.Push("Ali");
            linkedList.AddFirst("Ali");

            while (stack.Count != 0)
            {
                string element = stack.Pop();
                Console.WriteLine($"Stack: {element}");
            }

            node = linkedList.First;

            while (node != null)
            {
                Console.WriteLine($"Linked list: {node.Value}");
                linkedList.RemoveFirst();
                node = linkedList.First;
            }
        }
    }
}
