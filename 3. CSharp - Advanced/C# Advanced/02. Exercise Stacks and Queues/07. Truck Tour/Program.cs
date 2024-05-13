namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new();
            for (int i = 0; i < n; i++)
            {
                int[] info = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(info);
            }
            int currentIndex = 0;
            while (true) 
            {
                int fuel = 0;
                foreach (var pump in pumps)
                {
                    fuel += pump[0] - pump[1];
                    if (fuel < 0)
                    {
                        currentIndex++;
                        pumps.Enqueue(pumps.Dequeue());
                        break;
                    }
                }
                if (fuel >= 0)
                {
                    break;
                }
            }
            Console.WriteLine(currentIndex);
        }
    }
}
