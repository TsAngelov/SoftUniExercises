using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Temple_of_Doom
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> substances = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            List<int> challenges = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            while (true)
            {
                if (tools.Count == 0 || substances.Count == 0 || challenges.Count == 0)
                {
                    break;
                }
                int currentTool = tools.Dequeue();
                int currSubstance = substances.Pop();
                if (!challenges.Remove(currentTool * currSubstance))
                {
                    tools.Enqueue(++currentTool);
                    if (--currSubstance > 0)
                    {
                        substances.Push(currSubstance);
                    }
                }
            }
            if (challenges.Count > 0)
            {
                Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
            }
            else
            {
                Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
            }

            if (tools.Count > 0)
            {
                Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            }
            if (substances.Count > 0)
            {
                Console.WriteLine($"Substances: {string.Join(", ", substances)}");
            }
            if (challenges.Count > 0)
            {
                Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
            }
        }
    }
}
