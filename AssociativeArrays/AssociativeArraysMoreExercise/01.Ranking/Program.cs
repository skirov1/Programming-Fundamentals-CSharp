using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Ranking
{
    public class Student
    {
        public Student(string name)
        {
            Name = name;
            ContestWithPoints = new Dictionary<string, int>();
        }
        public string Name { get; set; }
        public Dictionary<string, int> ContestWithPoints { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            var listWithStudents = new List<Student>();

            while (true)
            {
                var data = Console.ReadLine().Split(":");
                if (data[0] == "end of contests")
                {
                    break;
                }
                contests.Add(data[0], data[1]);
            }

            while (true)
            {
                var data = Console.ReadLine().Split("=>");
                if (data[0] == "end of submissions")
                {
                    break;
                }
                var contest = data[0];
                var password = data[1];
                var username = data[2];
                var points = int.Parse(data[3]);

                if (!listWithStudents.Any(x => x.Name == username))
                {
                    var newStudent = new Student(username);
                    newStudent.ContestWithPoints = new Dictionary<string, int>();
                    newStudent.ContestWithPoints.Add(contest, points);
                    listWithStudents.Add(newStudent);
                }
                else
                {
                    var findStudent = listWithStudents.First(x => x.Name == username);
                    if (!findStudent.ContestWithPoints.Any(x => x.Key == contest))
                    {
                        findStudent.ContestWithPoints.Add(contest, points);
                    }
                    else
                    {
                        if (findStudent.ContestWithPoints[contest] < points)
                        {
                            findStudent.ContestWithPoints[contest] = points;
                        }
                    }
                }
            }
            PrintTheRanking(listWithStudents);
        }
        private static void PrintTheRanking(List<Student> listWithStudents)
        {
            var bestCandidate = listWithStudents.OrderByDescending(x => x.ContestsWithPoints.Values.Sum()).First();
            Console.WriteLine($"Best candidate is {bestCandidate.Name} with total {bestCandidate.ContestsWithPoints.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in listWithStudents.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                foreach (var (contest, points) in student.ContestsWithPoints.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}
