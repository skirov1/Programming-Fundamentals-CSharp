using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            
            while (true)
            {
                string[] cmd = Console.ReadLine().Split();

                if (cmd[0] == "3:1")
                {
                    break;
                }

                int startIndex = int.Parse(cmd[1]);
                int endIndex = int.Parse(cmd[2]);
                string word = "";

                if (endIndex > list.Count - 1 || endIndex < 0)
                {
                    endIndex = list.Count - 1;
                }
                if (startIndex > list.Count || startIndex < 0)
                {
                    startIndex = 0;
                }

                if (cmd[0] == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        word += list[i];
                    }
                    list.RemoveRange(startIndex, endIndex - startIndex + 1);
                    list.Insert(startIndex, word);
                }
                else if (cmd[0] == "divide")
                {
                    List<string> divideList = new List<string>();
                    int divide = int.Parse(cmd[2]);
                    string divideWord = list[startIndex];
                    list.RemoveAt(startIndex);
                    int parts = divideWord.Length / divide;

                    for (int i = 0; i < divide; i++)
                    {
                        if (i == divide - 1)
                        {
                            divideList.Add(divideWord.Substring(i * parts));
                        }
                        else
                        {
                            divideList.Add(divideWord.Substring(i * parts, parts));
                        }
                    }
                    list.InsertRange(startIndex, divideList);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
