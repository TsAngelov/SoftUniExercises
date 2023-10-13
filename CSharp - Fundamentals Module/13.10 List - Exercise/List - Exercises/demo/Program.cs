namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            for (int i = 0; i < 3; i++)
            {
                integers.Add(integers[0]);
                integers.RemoveAt(0);
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}