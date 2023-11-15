using System.Text.RegularExpressions;

namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"A\w+";
            Regex regex = new Regex(pattern);

            Match result = regex.Match("Aleksander e pi4");
            Console.WriteLine(result.Value);
        }
    }
}
