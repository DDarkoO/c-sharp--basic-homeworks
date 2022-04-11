using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass10Bonus.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public int Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, int halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public Cinema()
        {
        }

        public void MoviePlaying(Movie movie)
        {
            Console.WriteLine($"You are now watching the best movie ever - '{movie.Title}'! (insert happy face emoji here)");
        }




    }
}
