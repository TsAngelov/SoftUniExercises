namespace _03._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<string>> dictionary = new Dictionary<string,List<string>>();
            string[] wordPairs = Console.ReadLine().Split(" | ");
            foreach (string combination in wordPairs) 
            {
                string[] split = combination.Split(": ");
                string word = split[0];
                string definiton = split[1];
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word].Add(definiton);
                }
                else
                {
                    dictionary.Add(word, new List<string>());
                    dictionary[word].Add(definiton);
                }
            }
            string[] testWords = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();
            if (command == "Test")
            {
                foreach (var word in testWords)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        Console.Write(" -");
                        Console.WriteLine(string.Join("\n -", dictionary[word]));
                    }
                }
            }
            else
            {
                foreach (var word in dictionary)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}
