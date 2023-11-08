namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,double> orders = new Dictionary<string,double>();
            string input;
            while ((input = Console.ReadLine()) != "buy") 
            {
                string[] order = input.Split();
                string product = order[0];
                double price = double.Parse(order[1]);
                int quantity = int.Parse(order[2]);
                if (orders.ContainsKey(product))
                {
                    orders[product] += price * quantity;      
                }
                else
                {
                    orders.Add(product, price * quantity);    // price replaces with each  // quantity adds on
                }
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}