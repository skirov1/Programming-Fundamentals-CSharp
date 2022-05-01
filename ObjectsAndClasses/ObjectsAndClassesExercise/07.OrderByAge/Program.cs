using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0] == "End")
                {
                    break;
                }
                var name = data[0];
                var id = data[1];
                var age = int.Parse(data[2]);

                if (people.Any(person => person.ID == id))
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i].ID == id)
                        {
                            people[i].Name = name;
                            people[i].Age = age;
                            break;
                        }
                    }
                }
                else
                {
                    Person person = new Person(name, id, age);
                    people.Add(person);
                }

            }
            var orderedPeople = people.OrderBy(people => people.Age);
            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
