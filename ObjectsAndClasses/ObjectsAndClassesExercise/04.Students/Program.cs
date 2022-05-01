using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudent = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudent; i++)
            {
                string[] data = Console.ReadLine().Split();

                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);

                Student student = new Student();
                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;
                students.Add(student);
            }
            List<Student> orederedStudents = new List<Student>();
            orederedStudents = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in orederedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
