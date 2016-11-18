using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12_LINQ.Classes
{
    class MovieManager
    {
        List<Movie> movieList = new List<Movie>
        {
            new Movie {Title = "Taken", Genre = "Action", PlayTime = 93 },
            new Movie {Title = "Alien", Genre = "Horror", PlayTime = 117 },
            new Movie {Title = "Spider-Man", Genre = "Action", PlayTime = 121 },
            new Movie {Title = "Dumb and dumber", Genre = "Comedy", PlayTime = 107 },
            new Movie {Title = "The Notebook", Genre = "Romance", PlayTime = 123 }
        };

        public Movie[] AllTitles { get; set; }

        public void ShowSpecificMovie()
        {
            Console.Clear();
            Console.Write("Movie titles that contain \"Taken\": ");
            
            Movie singleMovie = movieList
                .Find(movie => String.Equals(movie.Title, "Taken"));
            Console.WriteLine(singleMovie.Title);
            Console.ReadKey();

        }

        public void ShowShortMovies()
        {
            Console.Clear();
            Console.WriteLine("Movies shorter than 120 min");
            Movie[] showShortMovies = movieList.Where(movie => movie.PlayTime <= 120).ToArray();
            foreach (var movie in showShortMovies)
            {
                Console.WriteLine(movie.Title + ": " + movie.PlayTime);
            }
            Console.ReadKey();
        }

        public void ShowMovieGenre()
        {
            Console.Clear();
            Console.WriteLine("Movies with action as genre:");
            Movie[] printGenre = movieList.Where(movie => movie.Genre.Contains("Action")).ToArray();
            foreach (var movie in printGenre)
            {
                Console.WriteLine(movie.Title + ": " + movie.Genre);
            }
            Console.ReadKey();
        }

        public void ShowMovieLINQ()
        {
            Console.Clear();
            Console.WriteLine("Movies that start with S is longer than 120 and is an actionmovie");
            Movie[] ShowLINQ = movieList.Where(movie => movie.Genre.Contains("Action")
            && movie.Title.Contains('S')
            && movie.PlayTime >= 120).ToArray();

            foreach (var item in ShowLINQ)
            {
                Console.WriteLine(item.Title + " - " + item.Genre + " - " + item.PlayTime + " min.");
            }
            Console.ReadKey();
        }
        public void ShowAllMovies()
        {
            Console.Clear();
            Console.WriteLine("All movies:");
            AllTitles = new Movie[5];
            for (int i = 0; i < AllTitles.Length; i++)
            {
                AllTitles[i] = new Movie { Title = movieList[i].Title };
            }
            foreach (var movie in AllTitles)
            {
                Console.WriteLine(movie.Title);
            }
            Console.ReadKey();
        }
    }
}
