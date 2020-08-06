using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {

        List<Movie> Movies = new List<Movie>()
        {

            new DVD("Shrek 4: Shrek shows up", Genre.Comedy, 180, new List<string>{ "shrek be shrekin", "shrek sings all star", "shrek gets paid"}),
            new DVD("National Lampoons Detroit Vacation", Genre.Comedy, 104, new List<string>{ "The Griswalds win a trip to Detroit", "The Griswalds arrive", "The Griswalds eat Greek food in Greek town", "The Griswalds get robbed because Rusty's car breaks down in west Detroit", "The Griswalds go to a Lions game", "The Lions win! (The best part of the movie)", "Everyone loves and respects Detroit now"}),
            new DVD("Fast and Furious 14: Retirement Racing", Genre.Action, 109, new List<string>{ "The 10 second Rascal Scooter", "Rascal Race for Will rights", "Granny shifting", "Old habits die hard... breaking into the pharmacy", "The slowest police chase", "One last ride" }),
            new VHS("Friday the 13th Part 12: Jason Learns to love himself", Genre.Drama, 90, new List<string>{ "Jason is resurrected... again", "Jason finds a therapist", "Jason overcomes the death of his mother", "Jason buries the machete", "Jason buys a quaint house in the suburbs and makes ice sculptures.", "Jason falls in love", "Jason's love interest dies from a tragic ice scultping accident", "Movie ends with Jason holding a shovel..." }),
            new VHS("The Godfather Part IV: The Bar Mitzvah", Genre.Action, 430, new List<string>{ "An offer you can refuse but probably shouldn't", "Accepted the offer, now I have to pay the piper", "Piper paid, bar mitzvah time!" } ),
            new VHS("The Nightmare on Elm Street: Freddy Teaches Kindergarten", Genre.Comedy, 132, new List<string>{ "The interview", "Hiring decision", "Okay, seriously though, who would hire Freddy Krueger as a Kindergarten teacher?", "Damn it, Carl. It's Freddy Krueger! We told you this would happen!" })
        };

        public virtual void PrintMovies()
        {
            int count = 1;

            foreach (Movie movie in Movies)
            {
                Console.WriteLine($"\t{count}) { movie.Title}");
                count++;
            }

        }
        public virtual void CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Please select a Movie from the list:");
            int selection = int.Parse(Console.ReadLine());

            Movies[selection - 1].PrintInfo();

            Console.WriteLine("Would you like to play this movie?");
            string decision = Console.ReadLine();

            if (decision == "y")
            {
                Movies[selection - 1].Play();
            }
            else
            {
                CheckOut();
            }
        }
    }
}
