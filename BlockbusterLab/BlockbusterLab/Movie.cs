using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public List<string> Scenes { get; set; }

        public string Title { get; set; }
        public int RunTime { get; set; }
        public Genre Genre { get; set; }

        public Movie() { }

        public Movie(List<string> Scenes)
        {
            this.Scenes = Scenes;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\tTitle: {Title}");
            Console.WriteLine($"\tCategory: {Genre}");
            Console.WriteLine($"\tRun time: {RunTime}");
        }
        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"\tScene number: {i + 1}");
                Console.WriteLine($"\tScene name: {Scenes[i]}");
            }
        }
        public abstract void Play();

    }
}
