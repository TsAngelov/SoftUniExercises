namespace _01._Offroad_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> initialFuel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> fuelConsumption = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> fuelNeeded = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int altitude = 1;
            bool didNotReach = false;

            while (initialFuel.Count != 0)
            {
                int currentFuel = initialFuel.Pop();
                int currentConsumption = fuelConsumption.Dequeue();
                int currentNeed = fuelNeeded.Dequeue();

                if (currentFuel - currentConsumption >= currentNeed)
                {
                    Console.WriteLine($"John has reached: Altitude {altitude++}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitude--}");
                    didNotReach = true;
                    break;
                }
            }
            if (didNotReach)
            {
                Console.WriteLine("John failed to reach the top.");
                if (altitude == 0)
                {
                    Console.WriteLine("John didn't reach any altitude.");
                }
                else
                {

                    Console.Write("Reached altitudes: ");
                    for (int i = 0; i < altitude; i++)
                    {
                        Console.Write($"Altitude {i + 1}");
                        if (i < altitude - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }
        }
    }
}
