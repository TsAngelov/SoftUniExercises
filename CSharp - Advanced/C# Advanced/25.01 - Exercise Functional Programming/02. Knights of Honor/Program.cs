namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> printSir = name => Console.WriteLine($"Sir {name}");

            Array.ForEach( input, printSir );
        }
    }
}
