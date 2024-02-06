namespace _06._Reverse_and_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int divisableNum = int.Parse(Console.ReadLine());

            Predicate<int> isDivisable = num => num % divisableNum != 0;

            numbers = numbers.Where(n => isDivisable(n)).ToArray();
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}
