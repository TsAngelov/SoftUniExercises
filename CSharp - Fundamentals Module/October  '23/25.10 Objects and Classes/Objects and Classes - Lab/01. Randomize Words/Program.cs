namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(input.Length);

                string currentWord = input[i];
                string randomWord = input[randomIndex];

                input[i] = randomWord;
                input[randomIndex] = currentWord;
            }
            Console.WriteLine(string.Join("\n", input));
        }
    }
}