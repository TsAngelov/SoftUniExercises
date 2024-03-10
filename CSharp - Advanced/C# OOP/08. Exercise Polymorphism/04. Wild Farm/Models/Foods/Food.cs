using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models.Foods
{
    public abstract class Food
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; }
    }
}
