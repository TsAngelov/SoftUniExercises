namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queue = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = 4;
            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    int emptySeats = 4 - lift[i];
                    queue -= emptySeats;
                    if (queue < 0)
                    {
                        lift[i] = 4 - Math.Abs(queue);
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", lift));
                        return;
                    }
                        lift[i] = 4;
                }
            }
            if (queue != 0)
            { 
                Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", lift));
        }
    }
}