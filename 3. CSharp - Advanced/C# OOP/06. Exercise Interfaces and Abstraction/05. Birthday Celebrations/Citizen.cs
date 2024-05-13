using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Citizen : LivingBeing, IBirthable, IIdentifiable
    {
        public Citizen(string name, string birthday, int age, string id) : base(name, birthday)
        {
            Name = name;
            Birthday = birthday;
            Id = id;
            Age = age;
        }
        public string Id { get; set; }
        public int Age { get; set; }
    }
}
