namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        Person person = new Person();

        Person person1 = new Person(2);

        Person person2 = new Person("petar", 3);
    }
}
