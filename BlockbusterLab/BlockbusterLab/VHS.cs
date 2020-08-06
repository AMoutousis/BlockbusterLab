using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        public VHS() { }
        public VHS(string title, Genre genre, int runtime, List<string> Scenes)
        {
            this.Title = title;
            this.Genre = genre;
            this.RunTime = runtime;
            this.Scenes = Scenes;
            CurrentTime = 0;
        }
        public override void Play()
        {
            bool keepWatching = true;

            while (keepWatching)
            {
                if (CurrentTime < Scenes.Count)
                {
                    Console.WriteLine(Scenes[CurrentTime]);
                    CurrentTime++;
                }
                else
                {
                    ValidateRewind();
                }

                Console.WriteLine("Would you like to watch the next scene?");
                string decision = Console.ReadLine();

                if (decision == "y")
                {
                    keepWatching = true;
                }
                else
                {
                    keepWatching = false;
                }

            }

        }
        public virtual void PrintInfo()
        {
            Console.WriteLine(Title, Genre, RunTime);
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public void ValidateRewind()
        {
            bool valid = true;

            while (valid)
            {
                Console.WriteLine("You've reached the end of the movie! Would you like to rewind?");
                string rewindCheck = Console.ReadLine();
                if (rewindCheck.ToLower() == "y")
                {
                    Rewind();
                    valid = false;
                }
                else if (rewindCheck.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                    valid = true;
                }
            }
        }

    }
}
