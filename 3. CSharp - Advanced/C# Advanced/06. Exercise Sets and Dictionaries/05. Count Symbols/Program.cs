namespace _05._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> charCount = new();

            foreach (var charve in input)
            {
                if (!charCount.ContainsKey(charve))
                {
                    charCount.Add(charve, 0);
                }
                    charCount[charve]++;

            }

            foreach (var charwe in charCount)
            {
                Console.WriteLine($"{charwe.Key}: {charwe.Value} time/s");
            }
        }
    }
}
