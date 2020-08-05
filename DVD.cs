using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD() { }
        public DVD(string title, string category, int runtime, List<string> Scenes)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runtime;
            this.Scenes = Scenes;
        }
        public override void Play()
        {
            Console.WriteLine("What scene would you like to play?");
            base.PrintScenes();

            int selectScene = int.Parse(Console.ReadLine());

            Console.WriteLine(Scenes[selectScene]);

        }



    }
}
