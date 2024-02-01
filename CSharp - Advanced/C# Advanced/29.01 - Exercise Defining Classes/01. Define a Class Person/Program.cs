namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "Peter";
        person.Age = 20;

        Person person2 = new Person();
        person2.Name = "George";
        person2.Age = 18;

        Person person3 = new Person();
        person3.Name = "Jose";
        person3.Age = 43;
    }
}
