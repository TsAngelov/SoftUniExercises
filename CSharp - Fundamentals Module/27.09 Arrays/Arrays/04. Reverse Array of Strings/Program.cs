namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < letters.Length / 2; i++)
            {
                string firstElement = letters[i];
                string lastElement = letters[letters.Length - 1 - i];
                letters[i] = lastElement;
                letters[letters.Length - 1 - i] = firstElement;
            }
            Console.WriteLine(string.Join(" ", letters));
        }
    }
}