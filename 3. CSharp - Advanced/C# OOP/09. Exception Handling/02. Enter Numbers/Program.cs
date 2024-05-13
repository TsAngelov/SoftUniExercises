namespace _02._Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            int[] numbers = new int[10];
            int currentIndex = 0;
            while (numbers[numbers.Length - 1] == default) // Until the last index is filled
            {
                try
                {
                    int currentNumber = ReadNumber(start, end);
                    start = currentNumber;
                    numbers[currentIndex] = currentNumber;
                    currentIndex++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }
            Console.WriteLine(String.Join(", ", numbers));
        }
        public static int ReadNumber(int start, int end)
        {

            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            }
            return number;
        }
    }
}
