namespace DoubleBoxSwap;

public class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Box<double> box = new();

        for (int i = 0; i < n; i++)
        {
            box.Add(double.Parse(Console.ReadLine()));
        }

        double check = double.Parse(Console.ReadLine());

        Console.WriteLine(box.CheckCount(check));
    }
}
