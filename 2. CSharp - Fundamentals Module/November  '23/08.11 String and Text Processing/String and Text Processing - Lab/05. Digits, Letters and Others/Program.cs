namespace _5._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(input.Where(x => Char.IsDigit(x)).ToArray());
            Console.WriteLine(input.Where(x => Char.IsLetter(x)).ToArray());
            Console.WriteLine(input.Where(x => !Char.IsLetterOrDigit(x)).ToArray());
        }
    }
}