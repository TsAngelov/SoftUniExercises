namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            bool isSpecialNum = false;
            for (int currentNumber = 1; currentNumber <= numbers; currentNumber++)
            {
                int sum = currentNumber % 10 + currentNumber / 10;
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecialNum);
            }
        }
    }
}