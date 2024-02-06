using System.Text;

namespace Threeuple;

public class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split();
        Threeuple<string, string, string> location = new();
        if (names.Length > 3)
        {
            var sb = new StringBuilder();
            for (int i = 3; i < names.Length; i++)
            {
                sb.Append(names[i] + " ");
            }
            location = new($"{names[0]} {names[1]}", names[2], sb.ToString());
        }
        else
        {
            location = new($"{names[0]} {names[1]}", names[2], names[2]);
        }

        string[] beerDrunk = Console.ReadLine().Split();
        Threeuple<string, int, bool> drunk = new(beerDrunk[0], int.Parse(beerDrunk[1]), (beerDrunk[2] == "drunk"));

        string[] bankInfo = Console.ReadLine().Split();
        Threeuple<string, double, string> bank = new(bankInfo[0], double.Parse(bankInfo[1]), bankInfo[2]);

        Console.WriteLine(location);
        Console.WriteLine(drunk);
        Console.WriteLine(bank);
    }
}
