using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_10_Delegater.Delegate;

namespace Labb_10_Delegater
{
    class Runtime
    {
        public void Start()
        {
            BookManager manager = new BookManager();

            Bookfilters isNovelFilter = BookFilter.IsNovel;
            Bookfilters IsShortStoryFilter = BookFilter.IsShortStory;
            Bookfilters IsGenreMysteryFilter = BookFilter.IsGenreMystery;
            Bookfilters IsGenreFantasyFilter = BookFilter.IsGenreFantasy;
            Bookfilters IsGenreRomanceFilter = BookFilter.IsGenreRomance;
            Bookfilters isCheapfilter = BookFilter.IsCheap;
            Bookfilters isExpensiveFilter = BookFilter.IsExpensive;

            Console.WriteLine("Novels: ");
            manager.PrintWhere(isNovelFilter);

            Console.WriteLine("\nShortstories: ");
            manager.PrintWhere(IsShortStoryFilter);

            Console.WriteLine("\nGenres: ");
            Console.WriteLine("Mystery books");
            manager.PrintWhere(IsGenreMysteryFilter);

            Console.WriteLine("\nFantasy books: ");
            manager.PrintWhere(IsGenreFantasyFilter);

            Console.WriteLine("\nRomance books: ");
            manager.PrintWhere(IsGenreRomanceFilter);

            Console.WriteLine("\nBooks over 200 kr: ");
            manager.PrintWhere(isExpensiveFilter);

            Console.WriteLine("\nBooks under 200 kr: ");
            manager.PrintWhere(isCheapfilter);

        }
    }
}
