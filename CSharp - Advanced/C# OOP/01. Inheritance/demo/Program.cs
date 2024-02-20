namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            student.Address = "Drujbai 1";
            student.LastName = "Patronov";
            student.University = "Vazov";

            Console.WriteLine(student.Address);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.University);

            student.Father = new Person { FirstName = "Gosho", LastName = "Patronov" };

            student.Sleep();
        }
    }
}
