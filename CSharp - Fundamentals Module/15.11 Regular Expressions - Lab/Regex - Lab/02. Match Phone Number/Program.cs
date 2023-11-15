using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([ -])2(\1)\d{3}(\1)\d{4}\b";
            string names = Console.ReadLine();
            MatchCollection matches = Regex.Matches(names, regex);

            var matchedPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
