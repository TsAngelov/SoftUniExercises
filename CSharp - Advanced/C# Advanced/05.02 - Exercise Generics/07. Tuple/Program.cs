namespace Tuple;

public class Program
{
    static void Main(string[] args)
    {
        string[] nameInput = Console.ReadLine().Split();
        CustomTuple<string, string> names = new($"{nameInput[0]} {nameInput[1]}", nameInput[2]);

        string[] beerInput = Console.ReadLine().Split();
        CustomTuple<string, double> beer = new(beerInput[0], double.Parse(beerInput[1]));

        string[] typeInput = Console.ReadLine().Split();
        CustomTuple<int, double> intDouble = new(int.Parse(typeInput[0]), double.Parse(typeInput[1]));

        Console.WriteLine(names);
        Console.WriteLine(beer);
        Console.WriteLine(intDouble);
    }
}
