namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());
            int lenght = numbers.Count;
            for (int i = 0; i < lenght/2; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count-1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}