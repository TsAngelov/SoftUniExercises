namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] split = input.Split().ToArray();
                string name = split[0];
                if (guests.Contains(name))
                {
                    if (input.Contains("not"))
                        guests.Remove(name);
                    else
                        Console.WriteLine(name + " is already in the list!");
                }
                else 
                {
                    if (input.Contains("not"))
                        Console.WriteLine(name + " is not in the list!");
                    else
                        guests.Add(name);
                }
                
            }
            Console.WriteLine(string.Join(" ", guests));
        }
    }
}