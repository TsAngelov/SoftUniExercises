namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
        }
    }
}