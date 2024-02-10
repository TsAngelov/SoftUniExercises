using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person? other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = Age.CompareTo(other.Age);
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }
            return Name == other.Name && Age == other.Age;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Age.GetHashCode();
        }
    }
}
