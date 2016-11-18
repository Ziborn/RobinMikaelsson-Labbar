using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Labb_10_Delegater.Delegate;

namespace Labb_10_Delegater
{
    class BookManager
    {
        public List<Book> BookList { get; set; }

        public BookManager()
        {
            BookList = new List<Book>
            {
                new Book {Title = "Nasses äventyr", Genre = "Romance", Pages = 52, Price = 99 },
                new Book {Title = "Alex springer", Genre = "Thriller", Pages = 783, Price = 299 },
                new Book {Title = "Skogsvandringen", Genre = "Fantasy", Pages = 230, Price = 249 },
                new Book {Title = "Polisskolan", Genre = "Crime", Pages = 400, Price = 159 },
                new Book {Title = "Trollskogen", Genre = "Mystery", Pages = 220, Price = 149 }
            };
        }
        public void PrintWhere(Bookfilters filter)
        {
            foreach (var book in BookList)
            {
                if(filter(book))
                    Console.WriteLine(book.Title);
            }
        }
    }
}
