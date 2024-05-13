namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zig = new int[n];
            int[] zag = new int[n];
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                
                int[] zigZagi = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 != 0)
                {
                    zig[counter] = zigZagi[0];
                    zag[counter] = zigZagi[1];
                    counter++;
                }
                else
                {
                    zig[counter] = zigZagi[1];
                    zag[counter] = zigZagi[0];
                    counter++;
                }
            }
            foreach (int number in zig)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            foreach (int number in zag)
            {
                Console.Write(number + " ");
            }
        }
    }
}