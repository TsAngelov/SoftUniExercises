namespace GenericArrayCreator;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(string.Join(", ", ArrayCreator.Create(50, "Fifty")));
    }
}
