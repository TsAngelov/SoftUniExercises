using System.Globalization;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            integers.Reverse();
            integers.RemoveAll(n => n < 0);
            if (integers.Count == 0)
                Console.WriteLine("empty");
            else
                Console.WriteLine(string.Join(" ", integers));
        }
    }
}