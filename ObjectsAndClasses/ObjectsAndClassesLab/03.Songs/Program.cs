using System;
using System.Collections.Generic;

namespace _03.Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string cmd = Console.ReadLine();
            if (cmd == "all")
            {
                foreach (var item in songs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                foreach (var item in songs)
                {
                    if (item.TypeList == cmd)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}
