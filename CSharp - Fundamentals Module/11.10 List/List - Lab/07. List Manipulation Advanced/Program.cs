namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            string input;
            bool changed = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] lineTokens = input.Split().ToArray();
                string command = lineTokens[0];
                switch (command)
                {
                    case "Add": case "Remove": case "RemoveAt": case "Insert":
                        ManipulationBasics(integers, input, lineTokens, command); changed = true; break;
                    case "Contains":
                        ContainsNum(integers, command, lineTokens); break;
                    case "PrintOdd":
                        PrintOdd(integers, command, lineTokens); break;
                    case "PrintEven":
                        PrintEven(integers, command, lineTokens); break;
                    case "GetSum":
                        Console.WriteLine(integers.Sum()); break;
                    case "Filter":
                        Filter(integers, command, lineTokens); break;
                }
            }
            if (changed)
            {
                Console.WriteLine(string.Join(" ", integers));
            }
        }
        static void ManipulationBasics(List<int> integers, string input, string[] lineTokens, string command)
        {
            int number = int.Parse(lineTokens[1]);
            switch (command)
            {
                case "Add":
                    integers.Add(number); break;
                case "Remove":
                    integers.Remove(number); break;
                case "RemoveAt":
                    integers.RemoveAt(number); break;
                case "Insert":
                    int index = int.Parse(lineTokens[2]);
                    integers.Insert(index, number); break;
            }

        }
        static void ContainsNum(List<int> integers, string input, string[] lineTokens)
        {
            int number = int.Parse(lineTokens[1]);
            if (integers.Contains(number))
                Console.WriteLine("Yes");
            else 
                Console.WriteLine("No such number");
        }
        static void PrintOdd(List<int> integers, string input, string[] lineTokens)
        {
            foreach (int number in integers)
            {
                if (number % 2 != 0)
                    Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void PrintEven(List<int> integers, string input, string[] lineTokens)
        {
            foreach (int number in integers)
            {
                if (number % 2 == 0)
                    Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void Filter(List<int> integers, string input, string[] lineTokens)
        {
            string filter = lineTokens[1];
            int number = int.Parse(lineTokens[2]);
            switch (filter) 
            {
                case "<":
                    foreach (int num in integers)
                    {
                        if (num < number)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
                case ">":
                    foreach (int num in temp)
                    {
                        if (num > number)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
                case ">=":
                    foreach (int num in temp)
                    {
                        if (num >= number)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
                case "<=":
                    foreach (int num in temp)
                    {
                        if (num <= number)
                        {
                            Console.Write(num + " ");
                        }
                    }
                    break;
            }
            Console.WriteLine();
        }
    }
}