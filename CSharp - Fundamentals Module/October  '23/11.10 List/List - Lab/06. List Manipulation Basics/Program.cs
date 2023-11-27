namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            string input;
            while ((input = Console.ReadLine()) != "end") 
            {
                string[] lineTokens = input.Split().ToArray();
                string command = lineTokens[0];
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
            Console.WriteLine(string.Join(" ",integers));
        }

    }
}