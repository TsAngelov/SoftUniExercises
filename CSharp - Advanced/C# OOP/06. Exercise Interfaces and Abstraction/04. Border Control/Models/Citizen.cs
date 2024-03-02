using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Citizen : BaseEntity
    {
        public Citizen(string id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
        }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
