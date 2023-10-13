namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] splitInput = input.Split().ToArray();
                string command = splitInput[0];
                int element = int.Parse(splitInput[1]);
                switch (command)
                {
                    case "Delete": integers.RemoveAll(x => x == element); break;
                    case "Insert": 
                        int index = int.Parse(splitInput[2]);
                        integers.Insert(index, element); break;
                }
            }
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}