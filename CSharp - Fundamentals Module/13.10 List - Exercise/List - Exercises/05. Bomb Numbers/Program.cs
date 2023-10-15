namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> factors = Console.ReadLine().Split().Select(int.Parse).ToList();
            int specNumber = factors[0];
            int power = factors[1];
            while (numbers.Contains(specNumber)) 
            {
                for (int i = 0; i < power; i++)
                {
                    int index = numbers.IndexOf(specNumber);
                    if (index + 1 >= numbers.Count)
                    {
                    }
                    else
                        numbers.RemoveAt(index + 1);
                    if (index - 1 >= numbers.Count)
                    {
                    }
                    else
                        numbers.RemoveAt(index - 1);
                }
                numbers.Remove(specNumber);
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}