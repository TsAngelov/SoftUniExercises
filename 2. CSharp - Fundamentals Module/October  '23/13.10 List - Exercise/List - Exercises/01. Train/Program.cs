namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int maxCapacity = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input.Contains("Add"))
                {
                    string[] command = input.Split().ToArray();
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(input) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(input);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}