namespace EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> peopleSorted = new SortedSet<Person>();
            HashSet<Person> peoplehash = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person newPerson = new Person(input[0], int.Parse(input[1]));

                peopleSorted.Add(newPerson);
                peoplehash.Add(newPerson);
            }
            Console.WriteLine(peopleSorted.Count);
            Console.WriteLine(peoplehash.Count);
        }
    }
}
