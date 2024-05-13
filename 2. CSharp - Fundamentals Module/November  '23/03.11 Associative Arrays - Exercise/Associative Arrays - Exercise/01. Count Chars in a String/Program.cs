namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<char, int> countChars = new Dictionary<char, int>();
            foreach (string word in words) 
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (countChars.ContainsKey(word[i]))
                    {
                        countChars[word[i]]++;
                    }
                    else
                    {
                        countChars.Add(word[i], 1);
                    }
                }
            }
            foreach (var item in countChars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}