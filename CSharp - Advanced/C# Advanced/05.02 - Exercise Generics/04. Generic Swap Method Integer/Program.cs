namespace IntBoxSwap;

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

        int[] indexSwap = Console.ReadLine().Split().Select(int.Parse).ToArray();
        box.Swap(indexSwap[0], indexSwap[1]);

        Console.WriteLine(box);
    }
}
