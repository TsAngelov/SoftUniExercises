namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int> function = x => x;
            Action<int[]> printNums = numbers => Console.WriteLine(string.Join(" ", numbers));

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        function = x => x + 1;
                        break;
                    case "multiply":
                        function = x => x * 2;
                        break;
                    case "subtract":
                        function = x => x - 1;
                        break;
                    case "print":
                        printNums(numbers);
                        function = x => x;
                        break;
                }
                numbers = numbers.Select(x => function(x)).ToArray();
            }
        }
    }
}
