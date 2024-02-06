namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            int throws = 1;
            while (names.Count != 1)
            {
                string personWithPotato = names.Dequeue();
                if (throws == n)
                {
                    Console.WriteLine($"Removed {personWithPotato}");
                    throws = 0;
                }
                else
                {
                    names.Enqueue(personWithPotato);
                }
                throws++;
            }
            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
