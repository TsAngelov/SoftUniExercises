namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> list = new List <Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student(input[0], input[1], double.Parse(input[2]));
                list.Add(student);
            }
            list = list.OrderByDescending(student => student.Grade).ToList();
            Console.WriteLine(string.Join("\n", list));
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}