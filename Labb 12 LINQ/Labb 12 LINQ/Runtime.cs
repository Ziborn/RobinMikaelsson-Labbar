using Labb_12_LINQ.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_12_LINQ
{
    class Runtime : MovieManager
    {
        public void Start()
        {
            bool loop = true;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("1. Movietitle");
                Console.WriteLine("2. Shortmovies");
                Console.WriteLine("3. Moviegenre");
                Console.WriteLine("4. MovieLINQ");
                Console.WriteLine("5. All movies");
                Console.WriteLine("6. Exit");

                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                        ShowSpecificMovie();
                        break;
                    case ConsoleKey.D2:
                        ShowShortMovies();
                        break;
                    case ConsoleKey.D3:
                        ShowMovieGenre();
                        break;
                    case ConsoleKey.D4:
                        ShowMovieLINQ();
                        break;
                    case ConsoleKey.D5:
                        ShowAllMovies();
                        break;
                    case ConsoleKey.D6:
                        loop = false;
                        break;
                }
            }
        }
    }
}
