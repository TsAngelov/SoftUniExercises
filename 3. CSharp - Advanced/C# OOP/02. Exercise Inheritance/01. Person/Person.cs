using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private int age;
        public string Name { get; set; }
        public virtual int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative!");
                }
                age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
