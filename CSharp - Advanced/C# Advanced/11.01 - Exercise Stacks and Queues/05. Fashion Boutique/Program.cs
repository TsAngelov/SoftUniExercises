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
            int currentSpace = 0;
            while (clothes.Count != 0)
            {
                int currentCloth = clothes.Pop();
                if (currentCloth + currentSpace > rackSize )
                {
                    rackCount++;
                    currentSpace = currentCloth;
                }
                else if (currentCloth + currentSpace == rackSize)
                {
                    rackCount++;
                    currentSpace = 0;
                }
                else
                    currentSpace += currentCloth;
            }
            Console.WriteLine(rackCount);
            
        }
    }
}
