using HomeworkClass10Bonus.Enums;
using HomeworkClass10Bonus.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkClass10Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Movie> moviesInCineplexxOne = new List<Movie>()
            {
                new Movie("Lord of the Rings - The fellowship of the ring", GenreEnum.SciFi, 5),
                new Movie("Lord of the Rings - The two towers", Enums.GenreEnum.SciFi, 5),
                new Movie("Lord of the Rings - The return of the king", Enums.GenreEnum.SciFi, 5),
                new Movie("Notebook", Enums.GenreEnum.Drama , 3),
                new Movie("Die hard", Enums.GenreEnum.Action, 2),
                new Movie("The ring", Enums.GenreEnum.Horror, 1),
                new Movie("Escape from LA", Enums.GenreEnum.SciFi, 2),
                new Movie("Me, Myself and Irine", Enums.GenreEnum.Comedy, 4),
                new Movie("Enemy at the gates", Enums.GenreEnum.Drama, 5),
                new Movie("Eternal sunshine of the spotless mind", Enums.GenreEnum.Drama, 4)
            };

            List<Movie> moviesInCineplexxTwo = new List<Movie>()
            {
                new Movie("Lalaland", Enums.GenreEnum.Drama, 4),
                new Movie("Rocky", Enums.GenreEnum.Action, 5),
                new Movie("Tetoviranje", Enums.GenreEnum.Drama, 5),
                new Movie("The sting", Enums.GenreEnum.Action, 5),
                new Movie("Star wars Episode 1", Enums.GenreEnum.Drama, 2),
                new Movie("It", Enums.GenreEnum.Horror, 3),
                new Movie("Ace Ventura - pet detective", Enums.GenreEnum.Comedy, 4),
                new Movie("Kada porastem bicu kengur", Enums.GenreEnum.Comedy, 3),
                new Movie("The silence of the lambs", Enums.GenreEnum.Drama, 5),
                new Movie("The last action hero", Enums.GenreEnum.Action, 1)
            };


            Cinema cineplexxOne = new Cinema("Cineplexx City Mall", 10, moviesInCineplexxOne);
            Cinema cineplexxTwo = new Cinema("Cineplexx East Gate Mall", 10, moviesInCineplexxTwo);

            PickCinema(cineplexxOne, cineplexxTwo);

        }


        static void PickCinema(Cinema cinemaOne, Cinema cinemaTwo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Good evening dear Sir/Madam! In which cinema would you like to go? \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1) Cineplexx City Mall \n2) Cineplexx East Gate"); 

            try
            {
                int choiceCinema = int.Parse(Console.ReadLine());
                if (choiceCinema != 1 && choiceCinema != 2)
                {
                    throw new Exception($"\n You have entered wrong choice! You must pick between 1 and 2!");
                }
                else if (choiceCinema == 1)
                {
                    PickMovieList(cinemaOne.Movies, cinemaOne);
                }
                else
                {
                    PickMovieList(cinemaTwo.Movies, cinemaTwo);
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

        }


        static void PickMovieList(List<Movie> movies, Cinema cinema)
        {
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine("\n Great choice! Now, would you like to:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" \n1) Check all movies we play at the moment, or\n2) Check only the movies from your favorite genre?\n");

            try
            {
                int choiceMovie = int.Parse(Console.ReadLine());

                if (choiceMovie != 1 && choiceMovie != 2)
                {
                    throw new Exception("Wrong input! Please chooce between 1 and 2!");
                }

                else if (choiceMovie == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n The following movies are currently playing in our cinema: \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    int counter = 1;
                    foreach (Movie movie in movies)
                    {
                        Console.WriteLine($"{counter}. {movie.Title} - Genre: {movie.Genre}. Rating: {movie.Rating}. Ticket price: {movie.TicketPrice}");
                        counter++;
                    }
                    PickMovieToWatch(movies, cinema);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Please pick your favorite genre out of the following genres:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n 1) Comedy \n 2) Horror \n 3) Action \n 4) Drama \n 5) SciFi");

                    try
                    {
                        int choiceGenre = int.Parse(Console.ReadLine());
                        if (choiceGenre < 1 || choiceGenre > 5)
                        {
                            throw new Exception("Invalid choice of movie genre. Please choose an option from 1 to 5 as per the list above!");
                        }
                        else
                        {
                            switch (choiceGenre)
                            {
                                case 1:
                                    ShowMoviesOfGenre(GenreEnum.Comedy, movies, cinema);
                                    break;
                                case 2:
                                    ShowMoviesOfGenre(GenreEnum.Horror, movies, cinema);
                                    break;
                                case 3:
                                    ShowMoviesOfGenre(GenreEnum.Action, movies, cinema);
                                    break;
                                case 4:
                                    ShowMoviesOfGenre(GenreEnum.Drama, movies, cinema);
                                    break;
                                case 5:
                                    ShowMoviesOfGenre(GenreEnum.SciFi, movies, cinema);
                                    break;
                                default:
                                    break;
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex);
                        Console.WriteLine(ex.Message);
                        Console.WriteLine(ex.StackTrace);
                    }
                    finally
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

        }


        static void ShowMoviesOfGenre(GenreEnum genre, List<Movie> movies, Cinema cinema)
        {

            

            List<Movie> moviesOfGenre = movies.Where(m => m.Genre == genre).ToList();

            if(moviesOfGenre.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"These movies of the genre {genre} are playing at the moment in our cinema:");
                Console.ForegroundColor = ConsoleColor.White;

                int counter = 1;
                foreach (Movie movie in moviesOfGenre)
                {
                    Console.WriteLine($"{counter}. '{movie.Title}'");
                    counter++;
                }

                PickMovieToWatch(moviesOfGenre, cinema);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("We are sorry, currently we don't play movies of your favorite genre :(");
            }

            

        }

        static void PickMovieToWatch(List<Movie> movieList, Cinema cinema)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n Please choose which movie from the ones above you would like to watch by choosing from 1 to {movieList.Count}");
            Console.ForegroundColor = ConsoleColor.White;

            try
            {
                int pickedMovie = int.Parse(Console.ReadLine());
                if (!(pickedMovie > 0 && pickedMovie <= movieList.Count))
                {
                    throw new ArgumentOutOfRangeException(nameof(pickedMovie));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    cinema.MoviePlaying(movieList[pickedMovie]);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nPlease visit our cinema again :)");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input, you must choose a number in the given range!");
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong input, please be careful next time!");
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
            }


        }


    }




}


