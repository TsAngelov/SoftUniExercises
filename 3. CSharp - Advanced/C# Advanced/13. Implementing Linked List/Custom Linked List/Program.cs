namespace Custom_Linked_List;

internal class Program
{
    static void Main(string[] args)
    {
        SoftUniLinkedList linkedList = new SoftUniLinkedList();

        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        linkedList.AddLast(4);

        linkedList.ForEach(n =>
        {
            Console.WriteLine(n);
        });

        int[] array = linkedList.ToArray();

        Console.WriteLine(string.Join(", ", array));

        //linkedList.RemoveFirst();
        //linkedList.RemoveLast();




    }
}
