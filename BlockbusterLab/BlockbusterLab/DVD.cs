using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD() { }
        public DVD(string title, Genre genre, int runtime, List<string> Scenes)
        {
            this.Title = title;
            this.Genre = genre;
            this.RunTime = runtime;
            this.Scenes = Scenes;
        }
        public override void Play()
        {
            Console.WriteLine("\tWhat scene would you like to play?");
            base.PrintScenes();

            int selectScene = int.Parse(Console.ReadLine());

            Console.WriteLine(Scenes[selectScene-1]);

            Console.WriteLine("Would you like to watch another scene");
            string decision = Console.ReadLine();

            if (decision == "y")
            {
                Play();
            }
            

        }



    }
}
