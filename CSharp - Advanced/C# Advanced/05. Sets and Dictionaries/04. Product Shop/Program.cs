namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new();

            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] info = input.Split(", ");
                string shop = info[0];
                string product = info[1];
                double price = double.Parse(info[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                if (!shops[shop].ContainsKey(product))
                {
                    shops[shop].Add(product, 0);
                }
                shops[shop][product] = price;
            }
            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
