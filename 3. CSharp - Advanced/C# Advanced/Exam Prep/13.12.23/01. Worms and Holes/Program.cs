namespace _01._Worms_and_Holes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> worms = new(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> holes = new(Console.ReadLine().Split().Select(int.Parse));

            int matchCount = 0;
            int wormsCount = worms.Count;

            while (true)
            {
                if (worms.Count == 0 || holes.Count == 0) break;

                int currentWorm = worms.Pop();
                int currenetHole = holes.Dequeue();

                if (currenetHole != currentWorm)
                {
                    currentWorm -= 3;
                    if (currentWorm > 0) worms.Push(currentWorm);            
                }
                else matchCount++;
            }
            if (matchCount > 0) Console.WriteLine($"Matches: {matchCount}");
            else Console.WriteLine("There are no matches.");

            if (worms.Count == 0)
            {
                if (wormsCount == matchCount)
                    Console.WriteLine("Every worm found a suitable hole!");
                else
                    Console.WriteLine("Worms left: none");
            }
            else
                Console.WriteLine($"Worms left: {string.Join(", ", worms)}");

            if (holes.Count == 0)
                Console.WriteLine("Holes left: none");
            else
                Console.WriteLine($"Holes left: {string.Join(", ", holes)}");
        }
    }
}
