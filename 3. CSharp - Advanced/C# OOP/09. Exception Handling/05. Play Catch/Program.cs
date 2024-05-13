using System;

namespace _05._Play_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();
            int exceptionCount = 0;

            while (exceptionCount < 3)
            {
                string[] command = Console.ReadLine().Split();
                try
                {
                    if (command[0] == "Replace")
                    {
                        int index = int.Parse(command[1]);
                        int element = int.Parse(command[2]);
                        array[index] = element;
                    }
                    else if (command[0] == "Show")
                    {
                        int index = int.Parse(command[1]);
                        Console.WriteLine(array[index]);
                    }
                    else if (command[0] == "Print")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            Console.Write(array[i]);
                            if (i < endIndex)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
