using Birthday.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Citizen : BaseEntity, IBirthdate
    {
        public Citizen(string id, int age, string name, string birthday)
        {
            Id = id;
            Age = age;
            Name = name;
            Birthday = birthday;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
    }
}
