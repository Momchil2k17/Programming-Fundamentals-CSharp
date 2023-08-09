using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split("_").ToArray();
                Song song = new Song(info[0], info[1], info[2]);
                songs.Add(song);
            }
            string constraint = Console.ReadLine();
            if (constraint == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (constraint == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }

                }
            }
        }

    }
    public class Song
    {
        public Song(string type, string name, string time)
        {
            TypeList = type;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
