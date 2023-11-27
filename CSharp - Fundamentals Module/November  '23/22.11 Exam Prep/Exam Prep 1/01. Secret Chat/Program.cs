namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretMessage = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] arg = input.Split(":|:");
                string command = arg[0];
                if (command == "InsertSpace")
                {
                    int index = int.Parse(arg[1]);
                    secretMessage = secretMessage.Insert(index, " ");
                }
                else if (command == "ChangeAll")
                {
                    string substring = arg[1];
                    string replacement = arg[2];
                    secretMessage = secretMessage.Replace(substring, replacement);
                }
                else
                {
                    string substring = arg[1];
                    int substringIndex = secretMessage.IndexOf(substring);
                    if (substringIndex == -1)
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    secretMessage = secretMessage.Remove(substringIndex, substring.Length);
                    string reversedSubstring = new string(substring.Reverse().ToArray());
                    secretMessage += reversedSubstring;
                }
                Console.WriteLine(secretMessage);
            }
            Console.WriteLine($"You have a new text message: {secretMessage}");
        }
    }
}
