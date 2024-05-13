using System;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string[] splitPeople = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            string[] splitProducts = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var person in splitPeople)
                {
                    string[] personInfo = person.Split('=');
                    string name = personInfo[0];
                    decimal money = decimal.Parse(personInfo[1]);
                    people.Add(new Person(name, money));
                }
                foreach (var product in splitProducts)
                {
                    string[] productInfo = product.Split('=');
                    string name = productInfo[0];
                    decimal money = decimal.Parse(productInfo[1]);
                    products.Add(new Product(name, money));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] purchaseInfo = input.Split();
                string person = purchaseInfo[0];
                string product = purchaseInfo[1];

                Person currentPerson = people.Find(p => p.Name == person);
                Product currentProduct = products.Find(p => p.Name == product);

                try
                {
                    if (person != null && product != null)
                    {
                        currentPerson.AddProduct(currentProduct);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                }
                catch(Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var p in people)
            {
                Console.Write($"{p.Name} - ");
                if (p.Bag.Count == 0)
                {
                    Console.Write("Nothing bought");
                }
                else
                {
                    Console.Write($"{string.Join(", ", p.Bag.Select(p => p.Name))}");
                }
                Console.WriteLine();
            }
        }
    }
}
