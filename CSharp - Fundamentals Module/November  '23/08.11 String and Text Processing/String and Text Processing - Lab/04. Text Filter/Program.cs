namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filters = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (string filter in filters)
            {
                string replacement = new string('*', filter.Length);
                text = text.Replace(filter, replacement);
            }
            Console.WriteLine(text);
        }
    }
}