using System;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] lineTokens = input.Split().ToArray();
                string command = lineTokens[0];
                if (input.Contains("Add"))
                {
                    int number = int.Parse(lineTokens[1]);
                    integers.Add(number);
                }
                else if (input.Contains("Remove"))
                {
                    int number = int.Parse(lineTokens[1]);
                    if (number > integers.Count - 1 || number < 0)
                        Console.WriteLine("Invalid index");
                    else
                        integers.RemoveAt(number);
                }
                else if (input.Contains("Insert"))
                {
                    int number = int.Parse(lineTokens[1]);
                    int index = int.Parse(lineTokens[2]);
                    if (index > integers.Count - 1 || index < 0)
                        Console.WriteLine("Invalid index");
                    else
                        integers.Insert(index, number);
                }
                else if (input.Contains("left"))
                {
                    int number = int.Parse(lineTokens[2]);
                    for (int i = 0; i < number; i++)
                    {
                        integers.Add(integers[0]);
                        integers.RemoveAt(0);
                    }
                }
                else if (input.Contains("right"))
                {
                    int number = int.Parse(lineTokens[2]);
                    for (int i = 0; i < number; i++)
                    {
                        for (int j = 0; j < integers.Count - 1; j++)
                        {
                            integers.Add(integers[0]);
                            integers.RemoveAt(0);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}