using HomeworkClass10Bonus.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkClass10Bonus.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public GenreEnum Genre { get; set; }

        private int _rating;
        public int TicketPrice { get; set; }


        public int Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                try
                {
                    if (!(value >= 1 && value <= 5))
                    {
                        throw new ArgumentOutOfRangeException("Invalid rating value. It must be between 1 and 5!");                        
                    }
                    else
                    {
                        _rating = value;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    _rating = 0;
                }
                finally
                {                    
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }


        public Movie(string title, GenreEnum genre, int rating)
        {
            Title = title;
            Rating = rating;
            Genre = genre;                      
            TicketPrice = 5 * rating;            
        }
        


    }
}
