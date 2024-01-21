namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new();
            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join("\n", usernames));
        }
    }
}
