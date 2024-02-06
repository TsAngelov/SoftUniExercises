namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> traffic = new Queue<string>();
            int n = int.Parse(Console.ReadLine());

            int passedCount = 0;
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (traffic.Count == 0)
                        {
                            continue;
                        }
                        Console.WriteLine($"{traffic.Dequeue()} passed!");
                        passedCount++;
                    }
                }
                else
                {
                    traffic.Enqueue(input);
                }
            }
            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
