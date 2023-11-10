namespace _02._Character_Mult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string first = strings[0];
            string second = strings[1];
            int sum = 0;
            for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
            {
                int currentNum1 = 1;
                int currentNum2 = 1;
                if (i < first.Length)
                    currentNum1 = (int)first[i];
                if (i < second.Length)
                    currentNum2 = (int)second[i];

                sum += currentNum1 * currentNum2;
            }
            Console.WriteLine(sum);
        }
    }
}