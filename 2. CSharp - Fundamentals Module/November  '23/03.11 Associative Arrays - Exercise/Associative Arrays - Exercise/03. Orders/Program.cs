namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> orders = new Dictionary<string, Product>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split();
                string product = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                Product productInfo = new Product(product, price, quantity);
                if (!orders.ContainsKey(product))
                {
                    orders.Add(productInfo.Name, productInfo);
                }
                else
                {
                    orders[product].Update(productInfo.Price, productInfo.Quantity);
                }
            }
            foreach (var item in orders)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
    public class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public void Update(decimal price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }
        public decimal GetTotal()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return $"{Name} -> {GetTotal():f2}";
        }
    }
}
}