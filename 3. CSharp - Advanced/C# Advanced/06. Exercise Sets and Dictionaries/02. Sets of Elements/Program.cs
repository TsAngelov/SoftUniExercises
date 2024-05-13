namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> n = new();
            HashSet<int> m = new();

            for (int i = 0; i < input[0]; i++)
            {
                n.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                m.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var num in n)
            {
                if (m.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
