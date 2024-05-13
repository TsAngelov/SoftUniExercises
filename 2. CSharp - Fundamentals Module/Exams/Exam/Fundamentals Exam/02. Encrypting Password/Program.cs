using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(.+)>(?<numbers>[0-9]{3})\|(?<lower>[a-z]{3})\|(?<upper>[A-Z]{3})\|(?<symbols>[^<>]{3})<(\1)";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string password = Console.ReadLine();
                if (Regex.IsMatch(password,pattern))
                {
                    MatchCollection matches = Regex.Matches(password, pattern);
                    foreach (Match match in matches)
                    {
                        string firstPart = match.Groups["numbers"].Value;
                        string secondPart = match.Groups["lower"].Value;
                        string thirdPart = match.Groups["upper"].Value;
                        string fourthPart = match.Groups["symbols"].Value;
                        Console.WriteLine($"Password: {firstPart + secondPart + thirdPart + fourthPart}");
                    }
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
