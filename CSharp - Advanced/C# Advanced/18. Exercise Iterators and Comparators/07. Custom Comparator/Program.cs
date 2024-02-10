namespace CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(array, new CustomComparator());

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
