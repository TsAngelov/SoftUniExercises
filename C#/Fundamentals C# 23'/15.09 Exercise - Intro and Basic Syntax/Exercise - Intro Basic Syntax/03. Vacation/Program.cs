namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            switch (group)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45 * people;
                            break;

                        case "Saturday":
                            price = 9.8 * people;
                            break;

                        case "Sunday":
                            price = 10.46 * people;
                            break;
                    }
                    if (people >= 30)
                    {
                        price = price - price * 0.15;
                    }
                    break;

                case "Business":
                    if (people >= 100)
                    {
                        people -= 10;
                    }
                    switch (day)
                    {
                        case "Friday":
                            price = 10.9 * people;
                            break;

                        case "Saturday":
                            price = 15.6 * people;
                            break;

                        case "Sunday":
                            price = 16 * people;
                            break;
                    }        
                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15 * people;
                            break;

                        case "Saturday":
                            price = 20 * people;
                            break;

                        case "Sunday":
                            price = 22.5 * people;
                            break;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        price = price - price * 0.05;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}