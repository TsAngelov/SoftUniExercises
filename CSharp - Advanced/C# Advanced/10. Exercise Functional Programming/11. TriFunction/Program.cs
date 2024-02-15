namespace _11._TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> largerSum = (string name, int sum) =>
            {
                return name.ToCharArray().Select(ch => (int)ch).Sum() >= sum;
            };

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr.FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, n, largerSum);
            Console.WriteLine(result);
        }
    }
}
