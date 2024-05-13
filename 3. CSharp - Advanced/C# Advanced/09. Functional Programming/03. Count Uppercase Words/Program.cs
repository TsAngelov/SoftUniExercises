namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<char> isCapital = n => char.IsUpper(n);
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => isCapital(n[0]))
                .ToArray();

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
