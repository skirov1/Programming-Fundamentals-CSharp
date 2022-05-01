using System;
using System.Collections.Generic;

namespace _05.Students2._0
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "end")
                {
                    break;
                }

                bool createStudent = true;
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].FirstName == firstName
                        && students[i].LastName == lastName)
                    {
                        students[i].Age = age;
                        students[i].HomeTown = homeTown;
                        createStudent = false;
                    }
                }

                if (createStudent)
                {
                    Student student = new Student();
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                    students.Add(student);
                }

            }
            string town = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.HomeTown == town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
