namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (string s in input) 
                {
                    periodicTable.Add(s);
                }
            }
            Console.WriteLine(string.Join(" ", periodicTable));
        }
    }
}
