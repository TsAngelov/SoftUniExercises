namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            GetCharsBetween(char1, char2);
        }

        static void GetCharsBetween(char c1, char c2)
        {
            if (c1 > c2)
            {
                char temp = ' ';
                temp = c1;
                c1 = c2;
                c2 = temp;
            }
            for (int i = (int)c1+1; i < (int)c2; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}