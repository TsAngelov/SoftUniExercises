namespace ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split();
                people.Add(new Person(info[0], int.Parse(info[1]), info[2]));
            }
            int position = int.Parse(Console.ReadLine());
            Person personComparable = people[position-1];

            int matches = 0, 
                notMatches = 0, 
                peopleCount = people.Count();
            foreach (var person in people)
            {
                if (personComparable.CompareTo(person) != 0)
                {
                    notMatches++;
                }
                else
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {notMatches} {peopleCount}");
            } 
        }
    }
}
