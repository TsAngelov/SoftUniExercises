using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public int CompareTo(Person? other)
        {
            int diff = Name.CompareTo(other.Name);
            if (diff == 0) 
            {
                diff = Age.CompareTo(other.Age);
                if (diff == 0)
                {
                   return Town.CompareTo(other.Town);
                }
                return diff;
            }
            return diff;
        }
    }
}
