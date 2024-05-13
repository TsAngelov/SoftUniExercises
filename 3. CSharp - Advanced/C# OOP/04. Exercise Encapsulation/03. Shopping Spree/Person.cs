using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
            bag = new List<Product>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public IReadOnlyCollection<Product> Bag => bag.AsReadOnly();
        public void AddProduct(Product product)
        {
            if (product.Cost > Money)
            {
                throw new ArgumentException($"{Name} can't afford {product.Name}");
            }
            else
            {
                bag.Add(product);
                Money -= product.Cost;
            }
        }
    }
}
