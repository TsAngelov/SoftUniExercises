namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> songQueue = new Queue<string>(songs);
            
            while (songQueue.Count != 0) 
            {
                string input = Console.ReadLine();
                if (input.Contains("Play"))
                {
                        songQueue.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    string song = input.Remove(0, 4); // starts from index 0 - index 3 which is the space after Add
                    if (songQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songQueue.Enqueue(song);
                    }
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", songQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
