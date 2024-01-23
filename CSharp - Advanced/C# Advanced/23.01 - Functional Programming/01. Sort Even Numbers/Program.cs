namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .Where(n => n%2 == 0)
                .OrderBy(n => n)
                .ToArray();
                
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
