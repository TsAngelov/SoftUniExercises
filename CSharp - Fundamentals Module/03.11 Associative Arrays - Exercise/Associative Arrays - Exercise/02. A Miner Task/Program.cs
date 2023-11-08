namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> ores = new Dictionary<string,int>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                string ore = input;
                int quantity = int.Parse(Console.ReadLine());
                if (ores.ContainsKey(ore))
                {
                    ores[ore] += quantity;
                }
                else
                {
                    ores.Add(ore, quantity);
                }
            }
            foreach (var item in ores)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}