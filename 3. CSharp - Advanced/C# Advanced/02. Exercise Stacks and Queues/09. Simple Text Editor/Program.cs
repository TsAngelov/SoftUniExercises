using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Stack<string> lastOperations = new();
            lastOperations.Push(sb.ToString());

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                switch (input[0])
                {
                    case "1":
                        string str = input[1];
                        sb.Append(str);
                        lastOperations.Push(sb.ToString());
                        break;
                    case "2":
                        int count = int.Parse(input[1]);

                        sb.Remove(sb.Length - count, count);
                        lastOperations.Push(sb.ToString());
                        break;
                    case "3":
                        int index = int.Parse(input[1]);
                        Console.WriteLine(sb[index - 1]);
                        break;
                    case "4":
                        lastOperations.Pop();
                        sb = new StringBuilder();
                        sb.Append(lastOperations.Peek());
                        break;
                        
                }
            }
        }
    }
}
