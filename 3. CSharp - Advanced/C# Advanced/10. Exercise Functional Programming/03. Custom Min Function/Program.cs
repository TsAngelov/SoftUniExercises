namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int[], int> printSmallest = input =>
            {
                int smallest = int.MaxValue;
                foreach (int num in input)
                {
                    if (smallest > num)
                    {
                        smallest = num;
                    }
                }
                return smallest;
            };

            Console.WriteLine(printSmallest(numbers));
        }
    }
}
