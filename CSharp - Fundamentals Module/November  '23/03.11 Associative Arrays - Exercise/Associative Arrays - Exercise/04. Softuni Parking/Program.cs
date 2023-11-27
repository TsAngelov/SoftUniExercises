namespace _04._Softuni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string name = input[1];
                if (command == "register")
                {
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[name]}");
                    }
                    else
                    {
                        string plate = input[2];
                        users.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        users.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var registration in users)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }
        }
    }
}
