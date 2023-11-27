namespace _03._SubString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string word = Console.ReadLine();
            while (word.Contains(substring))
            {
                int startindex = word.IndexOf(substring);
                word = word.Remove(startindex, substring.Length);
            }
            Console.WriteLine(word);
        }
    }
}