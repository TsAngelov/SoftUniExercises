namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }
            foreach (var student in courses)
            {
                Console.WriteLine($"{student.Key}: {student.Value.Count}");
                Console.Write("-- ");
                Console.WriteLine(string.Join("\n-- ", student.Value));
            }
        }
    }
}
