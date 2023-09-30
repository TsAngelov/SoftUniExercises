namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] tempArray = new int[numbers.Length];
            for (int i = 0; i < n; i++)
            {
                int temp = numbers[0];
                for (int j = 0; j < tempArray.Length - 1; j++)
                {
                    tempArray[j] = numbers[j + 1];
                }
                tempArray[numbers.Length - 1] = temp;
                numbers = tempArray;

            }
            foreach (int number in tempArray)
            {
                Console.Write(number + " ");
            }
        }
    }
}