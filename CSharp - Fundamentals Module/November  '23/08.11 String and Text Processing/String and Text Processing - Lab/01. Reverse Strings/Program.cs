 namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine()) != "end") 
            {
                Console.WriteLine($"{input} = {new string(input.Reverse().ToArray())}");
            }
        }
    }
}