using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            list2.Reverse();
            int shorterList = list1.Count;
            int longerList = list2.Count;
            if (list2.Count < list1.Count)
            {
                shorterList = list2.Count;
                longerList = list1.Count;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < shorterList; i++)
            {
                result.Add(list1[i]);
                result.Add(list2[i]);
            }

            int rangeStart = 0;
            int rangeEnd = 0;

            if (longerList == list1.Count)
            {
                rangeStart = list1[list1.Count - 2];
                rangeEnd = list1[list1.Count - 1];
            }
            else if (longerList == list2.Count)
            {
                rangeStart = list2[list2.Count - 2];
                rangeEnd = list2[list2.Count - 1];
            }

            if (rangeStart > rangeEnd)
            {
                int temp = rangeStart;
                rangeStart = rangeEnd;
                rangeEnd = temp;
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] <= rangeStart || result[i] >= rangeEnd)
                {
                    result.Remove(result[i]);
                    i--;
                }
            }

            result.Sort();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
