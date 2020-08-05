using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public List<string> Scenes { get; set; }

        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }

        public Movie() { }

        public Movie(List<string> Scenes)
        {
            this.Scenes = Scenes;
        }

        public void PrintInfo(string title, string category, int runtime)
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Run time: {runtime}");
        }
        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene number: {i + 1}");
                Console.WriteLine($"Scene name: {Scenes[i]}");
            }
        }
        public abstract void Play();

    }
}
