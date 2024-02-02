using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class Family
{
    private List<Person> people = new List<Person>();

    public void AddMember(Person member)
    {
        people.Add(member);
    }
    public Person GetOldestMember()
    {
        return people.FirstOrDefault(p => p.Age == people.Max(p => p.Age));
        //Person oldest = new(0);
        //foreach (var person in people)
        //{
        //    if (person.Age > oldest.Age)
        //    {
        //        oldest = person;
        //    }
        //}
    }
}
