namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int currentNumber = 0; currentNumber < numbers.Length; currentNumber++)
            {
                bool isGreater = true;
                for (int j = currentNumber + 1; j < numbers.Length; j++)
                {
                    if (numbers[currentNumber] <= numbers[j])
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    Console.Write(numbers[currentNumber] + " ");
                }
            }
        }
    }
}