namespace IntegerBox;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Box<int> box = new();

        for (int i = 0; i < n; i++)
        {
            box.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine(box);
    }
}
