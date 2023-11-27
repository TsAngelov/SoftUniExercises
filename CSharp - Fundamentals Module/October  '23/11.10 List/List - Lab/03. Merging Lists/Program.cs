using System.Net.Http.Headers;
using System.Numerics;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list1 = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());
            List<double> list2 = new List<double>(Console.ReadLine().Split().Select(double.Parse).ToList());
            List<double> result = new List<double>();
            for (int i = 0; i < Math.Max(list1.Count, list2.Count); i++)
            {
                if (i < list1.Count)
                {
                    result.Add(list1[i]);
                }
                if (i < list2.Count)
                {
                    result.Add(list2[i]);
                }  
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}