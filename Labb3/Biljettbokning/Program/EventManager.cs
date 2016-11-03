using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljettbokning
{
    class EventManager
    {
        public List<Event> bookedEvents = new List<Event>();
        
        public List<Movie> movieList = new List<Movie>
        {
        new Movie {Location = "Heron City", MovieName = "Around the world in 80 days",  MovieTime = "19:00", MoviePrice = 120 },
        new Movie {Location = "Saga", MovieName = "Djungle George",                     MovieTime = "20:00", MoviePrice = 120 },
        new Movie {Location = "Lasses Bio", MovieName = "Alex best day in the snow",    MovieTime = "21:00", MoviePrice = 120 }
         };

        public List<Festival> festivalList = new List<Festival>

            {
        new Festival {Location = "Stockholm", FestivalName = "80's Festival",       FestivalType = "80's Music", FestivalPrice = 599 },
        new Festival {Location = "Umeå", FestivalName = "90's Festival",            FestivalType = "90's Music", FestivalPrice = 699 },
        new Festival {Location = "Visby", FestivalName = "Party like it is 1999",   FestivalType = "Ultimate mix", FestivalPrice = 799 }
         };

        public List<Consert> consertList = new List<Consert>

            {
        new Consert {Location = "Stockholm", ConsertArtist = "Eminem",              ConsertGenre = "Hip hop n rap", ConsertPrice = 499 },
        new Consert {Location = "Göteborg", ConsertArtist = "Kiss",                 ConsertGenre = "Rock", ConsertPrice = 499 },
        new Consert {Location = "Stockholm", ConsertArtist = "Justin Bieber",       ConsertGenre = "Pop", ConsertPrice = 499 }
         };
        
        public void ShowEvents()
        {
            Console.Clear();
            Console.WriteLine("Movies");
            int i = 1;
            foreach (var movies in movieList)

            {
                Console.WriteLine("{0}. Name: {1}, Time: {2}", i, movies.MovieName, movies.MovieTime);
                i++;
            }
            Console.WriteLine("\nFestivals");
            int o = 1;
            foreach (var festival in festivalList)

            {

                Console.WriteLine("{0}. Name: {1}, Type: {2}", o, festival.FestivalName, festival.FestivalType);
                o++;
            }
            Console.WriteLine("\nConserts");
            int p = 1;
            foreach (var consert in consertList)

            {

                Console.WriteLine("{0}. Artist: {1}, Genre: {2}", p, consert.ConsertArtist, consert.ConsertGenre);
                p++;


            }

            Console.ReadLine();
        }
        
        public void BookEvent()
        {
            Console.Clear();
            Console.WriteLine("Choose what type of event you want to book:");
            Console.WriteLine("1. Movies: ");
            Console.WriteLine("2. Festival: ");
            Console.WriteLine("3. Consert: ");
            var input = Console.ReadKey(true).Key;

            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    BookMovie();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    BookFestival();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    BookConcert();
                    break;
            }
        }

        public void ShowConserts()
        {
            Console.Clear();
            Console.WriteLine("Choose Consert");
            int p = 1;
            foreach (var consert in consertList)

            {
                Console.WriteLine("{0}. Artist: {1} - Genre: {2} - Price: {3}", p, consert.ConsertArtist, consert.ConsertGenre, consert.ConsertPrice);
                p++;
            }
        }

        public void BookConcert()
        {
            ShowConserts();
            Console.Write("\nType in your name: ");
            string bookingName = Console.ReadLine();

            Console.Write("\nType in the number of the consert you want to book: ");
            int input = int.Parse(Console.ReadLine());
            consertList[input - 1].BookingName = bookingName;

            bookedEvents.Add(consertList[input - 1]);
            Console.WriteLine("{0} has been booked!", consertList[input - 1].ConsertArtist);
            Console.ReadLine();

        }

        private void ShowFestivals()
        {
            Console.Clear();
            Console.WriteLine("Choose Festival");
            int o = 1;
            foreach (var festival in festivalList)

            {

                Console.WriteLine("{0}. Name: {1} - Type: {2} - Price: {3} kr", o, festival.FestivalName, festival.FestivalType, festival.FestivalPrice);
                o++;
            }
            
        }

        public void BookFestival()
        {
            ShowFestivals();
            Console.Write("\nType in your name: ");
            string bookingName = Console.ReadLine();

            Console.Write("\nType in the number of the festival you want to book: ");
            int input = int.Parse(Console.ReadLine());
            festivalList[input - 1].BookingName = bookingName;

            bookedEvents.Add(festivalList[input - 1]);
            Console.WriteLine("{0} has been booked!", festivalList[input - 1].FestivalName);
            Console.ReadLine();
        }

        private void ShowMovies()
        {
            Console.Clear();
            Console.WriteLine("Choose Movie");
            int i = 1;
            foreach (var movies in movieList)

            {
                Console.WriteLine("{0}. Name: {1} - Time: {2} - Price: {3} kr", i, movies.MovieName, movies.MovieTime, movies.MoviePrice);
                i++;
            }
        }

        public void BookMovie()
        {
            ShowMovies();
            Console.Write("\nType in your name: ");
            string bookingName = Console.ReadLine();

            Console.Write("\nType in the number of the movie you want to book: ");
            int input = int.Parse(Console.ReadLine());
            movieList[input - 1].BookingName = bookingName;

            bookedEvents.Add(movieList[input - 1]);
            Console.WriteLine("{0} has been booked!", movieList[input - 1].MovieName);
            Console.ReadLine();

        }

        public void ShowBookedEvents()
        {
            Console.Clear();
            Console.WriteLine("Booked Events:");
            int i = 1;
            foreach (var Event in bookedEvents)
            {
                Console.WriteLine(i + Event.info()); i++;
            }
            Console.ReadLine();
        }

        
    }
}
