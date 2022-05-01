using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamilyMember
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    class Family
    {
        public List<Person> people = new List<Person>();

        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            var orderedPeople = people.OrderByDescending(person => person.Age).ToList();
            return orderedPeople[0];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();
                var name = data[0];
                var age = int.Parse(data[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
        }
    }
}
