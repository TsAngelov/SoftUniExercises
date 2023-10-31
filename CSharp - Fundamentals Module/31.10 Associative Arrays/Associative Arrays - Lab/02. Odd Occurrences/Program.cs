namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string toLower = word.ToLower();
                if (counts.ContainsKey(toLower)) 
                {
                    counts[toLower]++;
                }
                else
                {
                    counts.Add(toLower, 1);
                }
            }
            foreach (var word in counts)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}