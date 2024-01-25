namespace _01._Action_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = name => Console.WriteLine(name);

            Array.ForEach(input, print);
        }
    }
}
