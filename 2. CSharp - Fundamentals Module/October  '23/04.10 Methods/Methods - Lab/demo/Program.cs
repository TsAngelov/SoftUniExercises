namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime secondDate = firstDate.AddDays(1000-1);
            Console.WriteLine(secondDate.ToString("dd-MM-yyyy"));
        }
    }
}