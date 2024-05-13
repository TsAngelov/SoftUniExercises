namespace _01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(ArraySum(array));
        }

        static int ArraySum(int[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }

            int[] restArray = array.Skip(1).ToArray();

            return array[0] + ArraySum(restArray);
        }
    }
}
