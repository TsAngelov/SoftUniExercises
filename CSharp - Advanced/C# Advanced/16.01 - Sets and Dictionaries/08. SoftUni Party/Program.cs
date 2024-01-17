namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipList = new();
            HashSet<string> regularList = new();

            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipList.Add(input);
                }
                else
                {
                    regularList.Add(input);
                }
            }
            while ((input = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    vipList.Remove(input);
                }
                else
                {
                    regularList.Remove(input);
                }
            }

            Console.WriteLine(vipList.Count + regularList.Count);
            foreach (var res in vipList)
            {
                Console.WriteLine(res);
            }
            foreach (var res in regularList)
            {
                Console.WriteLine(res);
            }
        }
    }
}
