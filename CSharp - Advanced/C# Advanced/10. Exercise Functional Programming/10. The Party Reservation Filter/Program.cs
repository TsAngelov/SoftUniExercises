namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            List<string[]> operations = new List<string[]>();
            List<string> output = new List<string>(names);

            Predicate<string> predicate = null;

            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(";");
                string filterDo = command[0];
                string filterType = command[1];
                string filterParameter = command[2];

                if (filterDo == "Add filter")
                {
                    operations.Add(new string[] { filterType, filterParameter });
                }
                else
                {
                    operations.RemoveAll(x => x[0] == filterType && x[1] == filterParameter);
                }
            }

            foreach (var op in operations)
            {
                string filterType = op[0];
                string filterParameter = op[1];
                switch (filterType)
                {
                    case "Starts with":
                        predicate = name => name.StartsWith(filterParameter);
                        break;
                    case "Ends with":
                        predicate = name => name.EndsWith(filterParameter);
                        break;
                    case "Length":
                        predicate = name => name.Length == int.Parse(filterParameter);
                        break;
                    case "Contains":
                        predicate = name => name.Contains(filterParameter);
                        break;
                }
                output.RemoveAll(x => predicate(x));
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}