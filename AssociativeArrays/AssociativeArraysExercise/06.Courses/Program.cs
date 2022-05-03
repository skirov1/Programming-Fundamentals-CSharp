using System;
using System.Collections.Generic;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] data = Console.ReadLine().Split(" : ");
                if (data[0] == "end")
                {
                    break;
                }
                string course = data[0];
                string student = data[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }
                courses[course].Add(student);
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {courses[course.Key].Count}");
                foreach (var student in courses[course.Key])
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
