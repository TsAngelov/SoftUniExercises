namespace _07._Predicate_for_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            Predicate<string> lengthCheck = name => name.Length <= length;
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(n => lengthCheck(n)).ToArray();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
