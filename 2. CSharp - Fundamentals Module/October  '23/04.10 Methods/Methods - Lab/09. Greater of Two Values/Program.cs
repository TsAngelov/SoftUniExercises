namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                GetMax(a, b); 
            }
            else if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            else
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                GetMax(a, b);
            }
        }

        static void GetMax(string a, string b) 
        {
            double bigger = a.Length > b.Length ? a.Length : b.Length;
            for (int i = 0; i < bigger; i++)
            {
                if (a[i] > b[i])
                {
                    Console.WriteLine(a);
                    return;
                }
                else if (a[i] < b[i])
                {
                    Console.WriteLine(b);
                    return;
                }
            }
        }
        static void GetMax(int a, int b)
        {
            Console.WriteLine(a > b ? a : b); 
        }
        static void GetMax(char a, char b)
        {
            int value1 = a;
            int value2 = b;
            Console.WriteLine(a > b ? a : b);
        }
    }
}