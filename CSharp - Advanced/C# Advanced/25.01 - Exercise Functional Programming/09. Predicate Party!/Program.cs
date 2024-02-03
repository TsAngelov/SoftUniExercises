using System.Net.NetworkInformation;

namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            Predicate<string> predicate = null;
            Func<List<string>, Predicate<string>, List<string>> doubleAdd = (list, predicate) =>
            {
                List<string> result = new List<string>();
                foreach (var name in list)
                {
                    if (predicate(name))
                    {
                        result.Add(name);
                    }
                    result.Add(name);
                }
                return result;
            };
            Func<List<string>, Predicate<string>, List<string>> remove = (list, predicate) =>
            {
                return list.Where(list => predicate(list) == false).ToList();
            };

            string input;
            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] lineTokens = input.Split();
                string command = lineTokens[0];
                string criteria = lineTokens[1];
                switch (criteria)
                {
                    case "StartsWith":
                        string start = lineTokens[2];
                        predicate = n => n.StartsWith(start);
                        break;

                    case "EndsWith":
                        string end = lineTokens[2];
                        predicate = n => n.EndsWith(end);
                        break;

                    case "Length":
                        int length = int.Parse(lineTokens[2]);
                        predicate = n => n.Length == length;
                        break;
                }
                switch (command)
                {
                    case "Double":
                        names = doubleAdd(names, predicate);
                        break;
                    case "Remove":
                        names = remove(names, predicate);
                        break;
                }
            }
            if (names.Count == 0)
                Console.WriteLine("Nobody is going to the party!");
            else
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
        }
    }
}
