namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Petar";
            person.LastName = Console.ReadLine();
            person.Walk();

            Person person2 = new Person()
            {
                FirstName = "Ivan",
                LastName = "Petrakiev"
            };

            Person person3 = person2;
            person3.FirstName = "Petraki";

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);

            string test = person.LastName;

            TestMethod(person.LastName);
        }
        static void TestMethod(string name)
        {
            Console.WriteLine("hello " + name);
        }
    }

    class Person
    {
        public string FirstName { get; set; }  // public *type* *proterty name* { get; set; }
        public string LastName { get; set; }

        public void Walk()
        {
            Console.WriteLine("I am walking");
        }
    }
}