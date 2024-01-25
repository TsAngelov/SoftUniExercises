namespace _08._List_of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> numbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = n =>
            {
                bool isDivisable = true;
                foreach (var num in dividers)
                {
                    if (n % num != 0)
                    {
                        isDivisable = false;
                        break;
                    }
                }
                return isDivisable;
            };

            numbers = numbers.Where(n => predicate(n)).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
