namespace _04._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, bool> dic = new();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dic.ContainsKey(num))
                {
                    if (dic[num] == false)
                    {
                        dic[num] = true;
                    }
                    else
                    {
                        dic[num] = false;
                    }
                    continue;
                }
                dic.Add(num, false);
            }
            foreach (var num in dic) 
            {
                if (num.Value == true)
                {
                    Console.WriteLine(num.Key);
                    break;
                }
            }
        }
    }
}
