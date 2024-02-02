namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();
            customList.Add(3);
            customList.Add(3);
            customList.Add(4);
            customList.Add(4);
            customList.Add(7);

            customList.RemoveAt(1);

            Console.WriteLine(customList.Contains(7));

            customList.Swap(0, 3);

        }
    }
}
