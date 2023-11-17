using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>\w+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            string input;
            List<string> furniture = new List<string>();
            decimal moneySpent = 0;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string currentFurniture = match.Groups["furniture"].Value;
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furniture.Add(currentFurniture);
                    moneySpent += (decimal)price * (decimal)quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (string f in furniture)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine($"Total money spend: {moneySpent:f2}");
        }
    }
}
