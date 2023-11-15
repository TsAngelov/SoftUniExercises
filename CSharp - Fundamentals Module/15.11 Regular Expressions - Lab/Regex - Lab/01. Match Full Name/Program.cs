using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)";

            MatchCollection matchedNames = Regex.Matches(regex, pattern);
            foreach (Match match in matchedNames) 
            {
                Console.Write($"{match.Value} ");
            }
        }
    }
}