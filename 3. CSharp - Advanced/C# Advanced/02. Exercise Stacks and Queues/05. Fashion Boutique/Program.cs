namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothesSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackSize = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(clothesSize);
            int rackCount = 1;
            int currentSpace = rackSize;
            while (clothes.Count != 0)
            {
                if (clothes.Peek() <= currentSpace )
                {
                    currentSpace -= clothes.Pop();
                }
                else
                {
                    rackCount++;
                    currentSpace = rackSize;
                }
            }
            Console.WriteLine(rackCount);
            
        }
    }
}
