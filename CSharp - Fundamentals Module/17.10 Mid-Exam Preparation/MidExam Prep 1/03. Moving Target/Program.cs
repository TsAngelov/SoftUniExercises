namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] lineTokens = input.Split().ToArray();
                string command = lineTokens[0];
                int index = int.Parse(lineTokens[1]);
                int value = int.Parse(lineTokens[2]);
                if (command == "Shoot")
                {
                    if (IsValidIndex(index, targets))
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                if (command == "Add")
                {
                    if (!IsValidIndex(index, targets))
                        Console.WriteLine("Invalid placement!");
                    else
                        targets.Insert(index, value);
                }
                if (command == "Strike")
                {
                    if (IsValidIndex(index, targets) &&
                        IsValidIndex(index - value, targets) &&
                        IsValidIndex(index + value, targets))
                    {
                        int number = targets[index];
                        for (int i = 0; i < value; i++)
                        {
                            int curIndex = targets.IndexOf(number);
                            targets.RemoveAt(curIndex + 1);
                            targets.RemoveAt(curIndex - 1);
                        }
                        targets.Remove(number);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }
        static bool IsValidIndex(int index, List<int> targets)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}