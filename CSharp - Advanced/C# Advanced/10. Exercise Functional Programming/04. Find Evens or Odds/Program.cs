namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string check = Console.ReadLine();


            int startNum = input[0];
            int endNum = input[1];
            List<int> numbers = new List<int>();   
            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }
            
            Predicate<int> checkNumber = number =>
            {
                switch (check)
                {
                    case "odd":
                        return number % 2 != 0;
                    case "even":
                        return number % 2 == 0;
                }
                return false;
            };

            foreach (var num in numbers)
            {
                if (checkNumber(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
