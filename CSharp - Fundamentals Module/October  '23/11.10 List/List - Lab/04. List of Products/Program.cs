namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();
            for (int i = 1; i <= list.Count; i++)
            {
                list[i - 1] = ($"{i}.{list[i - 1]}");
            }
            Console.WriteLine(string.Join("\n", list));
        }
    }
}