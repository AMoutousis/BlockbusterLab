using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public override void Play()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[i]);
                CurrentTime++;
            }
        }
        public virtual void PrintScenes()
        { 
            
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(Title, Category, RunTime);
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }

    }
}
