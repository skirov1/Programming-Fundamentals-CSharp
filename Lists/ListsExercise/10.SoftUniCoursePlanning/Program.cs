using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string[] cmd = Console.ReadLine().Split(':').ToArray();
                string action = cmd[0];

                if (action == "course start")
                {
                    break;
                }

                if (action == "Add")
                {
                    string currentLecture = cmd[1];
                    if (!schedule.Contains(currentLecture))
                    {
                        schedule.Add(currentLecture);
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(cmd[2]);
                    string currentLecture = cmd[1];
                    if (!schedule.Contains(currentLecture))
                    {
                        if (index >= 0 && index < schedule.Count)
                        {
                            schedule.Insert(index, currentLecture);
                        }
                    }
                }
                else if (action == "Remove")
                {
                    string currentLecture = cmd[1];
                    schedule.Remove(currentLecture);
                    schedule.Remove(currentLecture + "-Exercise");
                }
                else if (action == "Swap")
                {
                    string lesson1 = cmd[1];
                    string lesson2 = cmd[2];
                    int lesson1Index = schedule.IndexOf(lesson1);
                    int lesson2Index = schedule.IndexOf(lesson2);

                    if (lesson1Index != -1 && lesson1Index != -1)
                    {
                        schedule[lesson1Index] = lesson2;
                        schedule[lesson2Index] = lesson1;
                        if (lesson1Index + 1 < schedule.Count && schedule[lesson1Index + 1] ==
                            $"{lesson1}-Exercise")
                        {
                            schedule.RemoveAt(lesson1Index + 1);
                            lesson1Index = schedule.IndexOf(lesson1);
                            schedule.Insert(lesson1Index + 1, $"{lesson1}-Exercise");
                        }
                        if (lesson2Index + 1 < schedule.Count && schedule[lesson2Index + 1] ==
                            $"{lesson2}-Exercise")
                        {
                            schedule.RemoveAt(lesson2Index + 1);
                            lesson2Index = schedule.IndexOf(lesson2);
                            schedule.Insert(lesson2Index + 1, $"{lesson2}-Exercise");
                        }
                    }
                }
                else if (action == "Exercise")
                {
                    string currentLecture = cmd[1];
                    int lessonIndex = schedule.IndexOf(currentLecture);
                    if (schedule.Contains(currentLecture) && !schedule.Contains($"{currentLecture }-Exercise"))
                    {
                        schedule.Insert(lessonIndex + 1, $"{currentLecture }-Exercise");
                    }
                    else if (!schedule.Contains(currentLecture))
                    {
                        schedule.Add(currentLecture);
                        schedule.Add($"{currentLecture}-Exercise");
                    }
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }
    }
}
