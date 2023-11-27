using System.Text;

namespace _06._Replace_Repeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder resutBuilder = new StringBuilder();
            resutBuilder.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i-1])
                {
                    resutBuilder.Append(input[i]);
                }
            }
            Console.WriteLine(resutBuilder);
        }
    }
}