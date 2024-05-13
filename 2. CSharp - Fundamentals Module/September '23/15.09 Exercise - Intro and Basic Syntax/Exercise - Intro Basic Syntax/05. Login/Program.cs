namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int attemptCount = 1;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            while (true)
            {
                string attempt = Console.ReadLine();
                if (attempt != password)
                {
                    if (attemptCount == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    attemptCount += 1;
                    Console.WriteLine("Incorrect password. Try again.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }

        }
    }
}