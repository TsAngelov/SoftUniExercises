namespace _01._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> text = new Stack<char>(Console.ReadLine().ToCharArray());

            //string input = Console.ReadLine();
            //foreach (var item in input)
            //{
            //    text.Push(item);
            //}

            while (text.Count > 0)
            {
                Console.Write(text.Pop());
            }
        }
    }
}
