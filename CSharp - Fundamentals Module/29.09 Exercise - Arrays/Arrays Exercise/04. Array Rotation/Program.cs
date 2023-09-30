namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                int[] tempArray = new int[numbers.Length];
                int temp = numbers[0];
                Array.Copy(numbers, 1, tempArray, 0, numbers.Length - 1);
                tempArray[tempArray.Length - 1] = temp;
                numbers = tempArray;

            }
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}