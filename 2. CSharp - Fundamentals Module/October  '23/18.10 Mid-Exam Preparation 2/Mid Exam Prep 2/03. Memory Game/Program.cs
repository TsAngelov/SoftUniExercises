using System.Reflection;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(3/2);
            List<string> elements = Console.ReadLine().Split().ToList();
            string input;
            int moves = 1;
            while ((input = Console.ReadLine()) != "end")
            {
                
                string[] indexes = input.Split();
                int index1 = int.Parse(indexes[0]);
                int index2 = int.Parse(indexes[1]);
                if (IsValidIndex(index1, index2, elements))
                {
                    if (elements[index1] == elements[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                        elements.RemoveAll(t => list.Contains(t.Name));
                    }
                    else
                        Console.WriteLine("Try again!");
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    elements.Insert(elements.Count/2, (-moves + "a"));
                    elements.Insert(elements.Count / 2, (-moves + "a"));
                }
                moves++;
            }
        }
        static bool IsValidIndex(int index1, int index2, List<string> elements)
        {
            if (index1 >= 0 && index1 < elements.Count &&
                index2 >= 0 && index2 < elements.Count &&
                index1 != index2)
                return true;
            else
                return false;
        }
    }
}