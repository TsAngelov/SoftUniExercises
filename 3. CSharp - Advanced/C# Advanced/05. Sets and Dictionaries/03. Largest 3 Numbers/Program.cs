namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = input.OrderByDescending(x => x).ToArray();

            if (sorted.Count() < 3)
            {
                Console.WriteLine(string.Join(" ", sorted));
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{sorted[i]} ");
                }
            }
        }
    }
}
