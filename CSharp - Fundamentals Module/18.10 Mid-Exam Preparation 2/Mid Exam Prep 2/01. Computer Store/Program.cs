namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0, taxes = 0;
            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if (price < 0)
                    Console.WriteLine("Invalid price!");
                else
                {
                    total += price;
                    taxes += price * 0.2;
                }
                input = Console.ReadLine();
            }
            double totalPrice = total + taxes;
            if (totalPrice > 0)
            {
                if (input == "regular")
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {total:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPrice:f2}$");
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {total:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPrice - totalPrice * 0.1:f2}$");
                }
            }
            else
                Console.WriteLine("Invalid order!");
        }
    }
}